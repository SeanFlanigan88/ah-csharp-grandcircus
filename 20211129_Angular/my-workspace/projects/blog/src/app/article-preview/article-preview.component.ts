import { Component, Input, OnInit } from '@angular/core';
import { ArticlePreview } from '../models/article-preview';

@Component({
  selector: 'app-article-preview',
  templateUrl: './article-preview.component.html',
  styleUrls: ['./article-preview.component.css']
})
export class ArticlePreviewComponent implements OnInit {

  @Input() content!: ArticlePreview;
  updated: string = "5 minutes"

  constructor() { }

  ngOnInit(): void {

  }

  printArticleToConsole() {
    console.log(`Button for ${this.content.title}`)
  }

}
