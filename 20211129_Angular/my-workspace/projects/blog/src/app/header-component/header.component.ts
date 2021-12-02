import { Component, OnInit } from '@angular/core'; 

@Component({
    selector: "blog-header",
    templateUrl: "./header.component.html"
})
export class HeaderComponent {
    title: string = "My Blog"

    constructor() {
        console.log("Header Constructed")
    }

    ngOnInit(): void {
        console.log("Header Initialized")
    }
}