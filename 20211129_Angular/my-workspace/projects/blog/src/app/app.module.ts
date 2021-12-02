import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header-component/header.component';
import { ArticlePreviewComponent } from './article-preview/article-preview.component';
import { ArticlePreviewListComponent } from './article-preview-list/article-preview-list.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ArticlePreviewComponent,
    ArticlePreviewListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
