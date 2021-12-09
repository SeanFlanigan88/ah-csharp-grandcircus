import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ArticleTempComponent } from './article-temp/article-temp.component';
import { ArticlePageComponent } from './article-page/article-page.component';
import { ArticlePreviewComponent } from './article-preview/article-preview.component';
import { ArticlePreviewListComponent } from './article-preview-list/article-preview-list.component';

@NgModule({
  declarations: [
    ArticleTempComponent,
    ArticlePageComponent,
    ArticlePreviewComponent,
    ArticlePreviewListComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ArticlePageComponent,
    ArticlePreviewComponent,
    ArticlePreviewListComponent
  ]
})
export class ArticleModule { }
