import { Component } from '@angular/core';

@Component({
  selector: 'app-page2',
  templateUrl: './page2.component.html',
  styleUrls: ['./page2.component.css']
})
export class Page2Component {
  title = 'GMS-client';

  ime = "Vedad"
  brojac = 0;

  Imena:string[] = []; // prazan niz
  NovoIme: any;

  Uvecaj(){
    this.brojac++;

    this.ime = this.ime + ".";
  }
  TestirajDugme(){

    alert("Hello FIT" + this.brojac);
  }

  IzmjenaTeksta($event: Event) {

    // @ts-ignore
    this.ime = $event.target.value
  }

  isVidljiv() {
    return this.brojac > 4;
  }

  StyleZaDiv() {
    if(this.brojac == 5){
      return {
        backgroundColor : 'yellow'
      }
    }
    else{
      return {
        backgroundColor : 'blue'
      }
    }

  }

  DodajNovoIme() {
    this.Imena .push(this.NovoIme)
  }
}
