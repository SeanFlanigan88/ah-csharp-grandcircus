import { Component, Input, OnInit } from '@angular/core';
import { ArticlePreview } from '../models/article-preview';
import { Router } from '@angular/router';

@Component({
  selector: 'app-article-preview',
  templateUrl: './article-preview.component.html',
  styleUrls: ['./article-preview.component.css']
})
export class ArticlePreviewComponent implements OnInit {

  @Input() content!: ArticlePreview;
  updated: string = "5 minutes"

  isLinkActive: boolean = false;
  linkToArticle: string = `#`;

  constructor(
    private router: Router
  ) { }

  ngOnInit(): void {
    this.linkToArticle = `/article/${this.content.title}`
  }

  printArticleToConsole() {
    console.log(`Button for ${this.content.title}`)
  }

  goToArticle() {
    this.router.navigate(['article', this.content.title])
  }

}
