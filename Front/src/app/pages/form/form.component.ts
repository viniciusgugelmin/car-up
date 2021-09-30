import { Component, OnInit } from "@angular/core";
import axios from "axios";

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

    createVendedor(
        vendedorNome: string,
        vendedorSobrenome: string,
        vendedorEmail: string
    ) {
        axios
            .post(`https://localhost:5001/api/vendedor`, {
                Nome: vendedorNome,
                Sobrenome: vendedorSobrenome,
                Email: vendedorEmail,
            })
            .then((response) => {
                alert("Success!");
            })
            .catch((error) => {
                console.log(error);
                alert("Error, check the console!");
            })
            .finally(() => {
                console.log("finally");
            });
    }
}
