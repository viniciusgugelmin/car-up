import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { ListComponent } from "./pages/list/list.component";
import { FormComponent } from "./pages/form/form.component";

@NgModule({
    declarations: [AppComponent, ListComponent, FormComponent],
    imports: [BrowserModule, AppRoutingModule],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}
