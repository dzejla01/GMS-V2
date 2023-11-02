import { Component } from '@angular/core';
import {config} from "rxjs";
import {Config} from "../config";
import {SuplementGetAllResponse} from "./Suplement-GetAll-Response";

@Component({
  selector: 'app-page3',
  templateUrl: './page3.component.html',
  styleUrls: ['./page3.component.css']
})
export class Page3Component {

  suplementi: SuplementGetAllResponse[] = [];

  GetSupplements() {

    let url = Config.adresa + 'Suplement/GetAll';
    fetch(url).then(x=>{
      if(x.status != 200){
        alert("Greska "+x.statusText)
        return;
      }
      x.json().then(r=>{
        this.suplementi = r;
      })
    })
  }
}
