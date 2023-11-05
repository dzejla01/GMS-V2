import { Component } from '@angular/core';
import {config} from "rxjs";
import {Config} from "../config";
import {SuplementGetAllResponse} from "./Suplement-GetAll-Response";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-page3',
  templateUrl: './page3.component.html',
  styleUrls: ['./page3.component.css']
})
export class Page3Component {


  constructor(public httpclient : HttpClient) {

  }

  suplementi: SuplementGetAllResponse[] = [];
  PretragaNaziv: string = "";

  GetSupplements() {

    let url = Config.adresa + 'Suplement/GetAll';
  /*  fetch(url).then(x=>{
      if(x.status != 200){
        alert("Greska "+x.statusText)
        return;
      }
      x.json().then(r=>{
        this.suplementi = r;
      })
    }) -- ovo je iz js
    */
    this.httpclient.get(url).subscribe((x:any )=>{
      this.suplementi = x;
    })


  }

  GetFiltiraniSuplementi() {
    return this.suplementi.filter(x=> x.naziv.toLowerCase().includes(this.PretragaNaziv.toLowerCase()));
  }
}
