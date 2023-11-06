import {Component, OnInit} from '@angular/core';
import {Config} from "../config";
import {HttpClient} from "@angular/common/http";
import {KorisniciGetAllResponse, KorisniciGetAllResponseKorisnik} from "./KorisnikGetAllResponse";

@Component({
  selector: 'app-page4',
  templateUrl: './page4.component.html',
  styleUrls: ['./page4.component.css']
})
export class Page4Component implements OnInit{


  constructor(public httpclient : HttpClient) {

  }

  korisnici: KorisniciGetAllResponseKorisnik[] = [];
  PretragaNaziv: string = "";
  ngOnInit():void  {


    let url = Config.adresa + 'Korisnik-GetAll';

    this.httpclient.get<KorisniciGetAllResponse>(url).subscribe((x:KorisniciGetAllResponse )=>{
      this.korisnici = x.korisnici;
    })




  }

  GetFiltiraniKorisnici() {
    return this.korisnici.filter(x=> x.ime.toLowerCase().includes(this.PretragaNaziv.toLowerCase()) || x.prezime.toLowerCase().includes(this.PretragaNaziv.toLowerCase()));
  }



}
