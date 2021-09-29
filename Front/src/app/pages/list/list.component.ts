import { Component, OnInit } from "@angular/core";

@Component({
    selector: "app-root",
    templateUrl: "./list.component.html",
})
export class ListComponent implements OnInit {
    title = "Car - list";

    // mounted
    ngOnInit(): void {
        this.getTitle();
    }

    getTitle() {
        document.title = this.title;
    }
}
