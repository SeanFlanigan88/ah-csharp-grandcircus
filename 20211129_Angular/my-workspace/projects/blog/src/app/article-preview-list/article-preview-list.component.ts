import { Component, OnInit } from '@angular/core';
import { ArticlePreview } from '../models/article-preview';

@Component({
  selector: 'app-article-preview-list',
  templateUrl: './article-preview-list.component.html',
  styleUrls: ['./article-preview-list.component.css']
})
export class ArticlePreviewListComponent implements OnInit {

  articles: ArticlePreview[] = [];

  constructor() { }

  ngOnInit(): void {
    this.addDefaultArticles();
  }

  addDefaultArticles() {
    this.articles.push(new ArticlePreview("Article 1", "This is the summary of an article."));
    this.articles.push(new ArticlePreview("Article 2", "This is the summary of an article."));
    this.articles.push(new ArticlePreview("Article 3", "This is the summary of an article."));
    this.articles.push(new ArticlePreview("Article 4", "This is the summary of an article."));
  }

}
