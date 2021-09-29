import { Component, OnInit } from "@angular/core";

@Component({
    selector: "app-root",
    templateUrl: "./form.component.html",
})
export class FormComponent implements OnInit {
    title = "Car - form";

    // mounted
    ngOnInit(): void {
        this.getTitle();
    }

    getTitle() {
        document.title = this.title;
    }
}
