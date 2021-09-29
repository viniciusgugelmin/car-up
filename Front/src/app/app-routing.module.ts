import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ListComponent } from "./pages/list/list.component";
import { FormComponent } from "./pages/form/form.component";

const routes: Routes = [
    { path: "list", component: ListComponent },
    { path: "form", component: FormComponent },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
