import { Component, OnInit } from '@angular/core';
import { ArticleAPIService } from '../services/article-api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(
    private apiSvc: ArticleAPIService
  ) { }

  ngOnInit(): void {
    this.apiSvc.getPingStatus().subscribe((ping) => {
      console.log("[INFO]")
      console.log(ping);
    })
  }

}
