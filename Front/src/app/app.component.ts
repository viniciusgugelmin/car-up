import { Component, OnInit } from "@angular/core";

@Component({
    selector: "app-root",
    templateUrl: "./app.component.html",
})
export class AppComponent implements OnInit {
    title = "Car";

    // mounted
    ngOnInit(): void {
        document.title = this.title;
    }
}
