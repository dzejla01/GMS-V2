import {Component, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Config} from "../config";
import {
  KorisniciGetAllResponseFrontend,
  KorisniciGetAllResponseFrontendKorisnik
} from "./KorisnikGetAllResponseFrontend";

@Component({
  selector: 'app-page4frontend',
  templateUrl: './page4frontend.component.html',
  styleUrls: ['./page4frontend.component.css']
})
export class Page4frontendComponent implements OnInit{

  constructor(public httpclient : HttpClient) {

  }

  korisnici: KorisniciGetAllResponseFrontendKorisnik[] = [];
  PretragaNaziv: string = "";
  ngOnInit():void {

    let url = Config.adresa + 'Korisnik-Search';

    this.httpclient.get<KorisniciGetAllResponseFrontend>(url).subscribe((x:KorisniciGetAllResponseFrontend )=>{
      this.korisnici = x.korisnici;
    })




  }

  PreuzmiNovePodatke($event: Event) {
    // @ts-ignore
    let naziv = $event.target.value;
    let url = Config.adresa + `Korisnik-Search?Pretraga=${naziv}`;

    this.httpclient.get<KorisniciGetAllResponseFrontend>(url).subscribe((x:KorisniciGetAllResponseFrontend )=>{
      this.korisnici = x.korisnici;
    })

  }
}
