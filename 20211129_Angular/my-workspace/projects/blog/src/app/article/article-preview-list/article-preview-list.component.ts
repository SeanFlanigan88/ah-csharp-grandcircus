import { Component, OnInit } from '@angular/core';
import { ArticlePreview } from '../../models/article-preview';
import { ArticleAPIService } from '../../services/article-api.service';
import { LoggerService } from '../../services/logger.service';

@Component({
  selector: 'app-article-preview-list',
  templateUrl: './article-preview-list.component.html',
  styleUrls: ['./article-preview-list.component.css']
})
export class ArticlePreviewListComponent implements OnInit {

  counter: number = 0;
  articles: ArticlePreview[] = [];

  constructor(
    private articleAPISvc: ArticleAPIService,
    private logSvc: LoggerService
  ) { }

  ngOnInit(): void {
    this.addDefaultArticles();
    this.logSvc.log("ArticlePreviewListComponent")
  }

  addDefaultArticles() {
    this.articles = this.articleAPISvc.getAllArticles();
  }

  addCounterEvent(num: number) {
    this.counter += num;
  }

}
