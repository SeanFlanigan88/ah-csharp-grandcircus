import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ArticlePreview } from '../models/article-preview';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { PingResponse } from '../models/pingResponse';

@Injectable({
    providedIn: 'root',
})
export class ArticleAPIService {
    constructor(
        private httpClient: HttpClient
    ) { }

    getAllArticles(): ArticlePreview[] {
        var articles: ArticlePreview[] = [];        

        articles.push(new ArticlePreview("New Article 1", "This is the summary of an article."));
        articles.push(new ArticlePreview("New Article 2", "This is the summary of an article."));
        articles.push(new ArticlePreview("New Article 3", "This is the summary of an article."));
        articles.push(new ArticlePreview("New Article 4", "This is the summary of an article."));

        return articles;
    }

    getPingStatus(): Observable<PingResponse> {
        return this.httpClient.get<PingResponse>("");
    }
}