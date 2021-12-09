import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { LoggerService } from '../../services/logger.service';

@Component({
  selector: 'app-article-page',
  templateUrl: './article-page.component.html',
  styleUrls: ['./article-page.component.css']
})
export class ArticlePageComponent implements OnInit {

  titleId: string = "N/A"

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private logSvc: LoggerService
  ) { }

  ngOnInit(): void {
    this.logSvc.log("ArticlePreviewComponent");
    console.log(this.route.snapshot.root);
    console.log(this.route.snapshot.url);
    const title = this.route.snapshot.paramMap.get('name');
    if (title) {
      this.titleId = title;
    }
  }

  goToArticles() {
    this.router.navigate(["articles"])
  }

}
