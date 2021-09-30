import { Component, OnInit, ElementRef, ViewChild } from "@angular/core";
import axios from "axios";

@Component({
    selector: "app-root",
    templateUrl: "./list.component.html",
})
export class ListComponent implements OnInit {
    title = "Car - list";
    vendedores = [];
    marcas = [];
    modelos = [];
    veiculos = [];

    // mounted
    ngOnInit(): void {
        this.getTitle();
        this.getVendedores();
        this.getMarcas();
        this.getModelos();
        this.getVeiculos();
    }

    getTitle() {
        document.title = this.title;
    }

    getVendedores() {
        var tbodyVendedores = document.querySelector("#up-list__vendedor");

        axios
            .get(`https://localhost:5001/api/vendedor/`)
            .then((response) => {
                if (tbodyVendedores) {
                    tbodyVendedores.innerHTML = "";
                }

                this.vendedores = response.data;

                for (let i = 0; i < this.vendedores.length; i++) {
                    var row = tbodyVendedores?.appendChild(
                        document.createElement("tr")
                    );

                    if (row) {
                        row.insertCell().innerHTML = this.vendedores[i]["id"];
                        row.insertCell().innerHTML = this.vendedores[i]["nome"];
                        row.insertCell().innerHTML =
                            this.vendedores[i]["sobrenome"];
                        row.insertCell().innerHTML =
                            this.vendedores[i]["email"];
                        row.insertCell().innerHTML =
                            this.vendedores[i]["createdAt"];
                    }
                }
            })
            .catch((error) => {
                console.log(error);
                alert("Error, check the console!");
            })
            .finally(() => {
                console.log("finally");
            });
    }

    getMarcas() {
        var tbodyMarcas = document.querySelector("#up-list__marcas");

        axios
            .get(`https://localhost:5001/api/marca/`)
            .then((response) => {
                if (tbodyMarcas) {
                    tbodyMarcas.innerHTML = "";
                }

                this.marcas = response.data;

                for (let i = 0; i < this.marcas.length; i++) {
                    var row = tbodyMarcas?.appendChild(
                        document.createElement("tr")
                    );

                    if (row) {
                        row.insertCell().innerHTML = this.marcas[i]["id"];
                        row.insertCell().innerHTML = this.marcas[i]["nome"];
                        row.insertCell().innerHTML =
                            this.marcas[i]["fabricante"];
                        row.insertCell().innerHTML =
                            this.marcas[i]["representante"];
                        row.insertCell().innerHTML =
                            this.marcas[i]["createdAt"];
                    }
                }
            })
            .catch((error) => {
                console.log(error);
                alert("Error, check the console!");
            })
            .finally(() => {
                console.log("finally");
            });
    }

    getModelos() {
        var tbodyModelos = document.querySelector("#up-list__modelos");

        axios
            .get(`https://localhost:5001/api/modelo/`)
            .then((response) => {
                if (tbodyModelos) {
                    tbodyModelos.innerHTML = "";
                }

                this.modelos = response.data;

                for (let i = 0; i < this.modelos.length; i++) {
                    var row = tbodyModelos?.appendChild(
                        document.createElement("tr")
                    );

                    if (row) {
                        row.insertCell().innerHTML = this.modelos[i]["id"];
                        row.insertCell().innerHTML = this.modelos[i]["marcaId"];
                        row.insertCell().innerHTML = this.modelos[i]["nome"];
                        row.insertCell().innerHTML =
                            this.modelos[i]["categoria"];
                        row.insertCell().innerHTML = this.modelos[i]["versao"];
                        row.insertCell().innerHTML =
                            this.modelos[i]["createdAt"];
                    }
                }
            })
            .catch((error) => {
                console.log(error);
                alert("Error, check the console!");
            })
            .finally(() => {
                console.log("finally");
            });
    }

    getVeiculos() {
        var tbodyVeiculos = document.querySelector("#up-list__veiculos");

        axios
            .get(`https://localhost:5001/api/veiculo/`)
            .then((response) => {
                if (tbodyVeiculos) {
                    tbodyVeiculos.innerHTML = "";
                }

                this.veiculos = response.data;

                for (let i = 0; i < this.veiculos.length; i++) {
                    var row = tbodyVeiculos?.appendChild(
                        document.createElement("tr")
                    );

                    if (row) {
                        row.insertCell().innerHTML = this.veiculos[i]["id"];
                        row.insertCell().innerHTML =
                            this.veiculos[i]["modeloId"];
                        row.insertCell().innerHTML = this.veiculos[i]["nome"];
                        row.insertCell().innerHTML = this.veiculos[i]["cor"];
                        row.insertCell().innerHTML =
                            this.veiculos[i]["combustivelPrincipal"];
                        row.insertCell().innerHTML =
                            this.veiculos[i]["createdAt"];
                    }
                }
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
