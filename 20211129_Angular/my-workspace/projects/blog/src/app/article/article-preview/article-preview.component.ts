import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { ArticlePreview } from '../../models/article-preview';
import { Router } from '@angular/router';
import { LoggerService } from "../../services/logger.service";

@Component({
  selector: 'app-article-preview',
  templateUrl: './article-preview.component.html',
  styleUrls: ['./article-preview.component.css']
})
export class ArticlePreviewComponent implements OnInit {

  @Input() content!: ArticlePreview;
  @Output() newEvent = new EventEmitter<number>();
  updated: string = "5 minutes"

  isLinkActive: boolean = false;
  linkToArticle: string = `#`;

  constructor(
    private router: Router,
    private logSvc: LoggerService
  ) { }

  ngOnInit(): void {
    this.linkToArticle = `/article/${this.content.title}`
    this.logSvc.log("ArticlePreviewComponent");
  }

  printArticleToConsole() {
    console.log(`Button for ${this.content.title}`)
  }

  goToArticle() {
    this.router.navigate(['article', this.content.title])
  }

  triggerOutput() {
    this.newEvent.emit(1)
  }

}
