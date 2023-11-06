
export interface KorisniciGetAllResponse{
  korisnici : KorisniciGetAllResponseKorisnik[];

}

export interface KorisniciGetAllResponseKorisnik {
  id: number
  ime: string
  prezime: string
  teretanaNaziv: string
  gradNaziv: string
  spolNaziv: string
  tezina: number
  visina: number
}
