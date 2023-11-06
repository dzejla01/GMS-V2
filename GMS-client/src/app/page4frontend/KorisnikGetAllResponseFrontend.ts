
export interface KorisniciGetAllResponseFrontend{
  korisnici : KorisniciGetAllResponseFrontendKorisnik[];

}

export interface KorisniciGetAllResponseFrontendKorisnik {
  id: number
  ime: string
  prezime: string
  teretanaNaziv: string
  gradNaziv: string
  spolNaziv: string
  tezina: number
  visina: number
}
