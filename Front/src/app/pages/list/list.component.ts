import { Component, OnInit } from "@angular/core";

@Component({
    selector: "app-root",
    templateUrl: "./list.component.html",
})
export class ListComponent implements OnInit {
    title = "Car - list";

    // mounted
    ngOnInit(): void {
        document.title = this.title;
    }
}
