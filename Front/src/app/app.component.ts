import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    selector: "app-root",
    templateUrl: "./app.component.html",
})
export class AppComponent implements OnInit {
    title = "Car";

    constructor(private router: Router) {}

    // mounted
    ngOnInit(): void {
        document.title = this.title;

        if (this.router.url === "/") {
            this.redirect();
        }
    }

    redirect() {
        this.router.navigate(["list"]);
    }
}
