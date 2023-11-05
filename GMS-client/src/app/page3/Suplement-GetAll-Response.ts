
  export interface SuplementGetAllResponse {
  id: number
  naziv: string
  cijena: number
  gramaza: number
  slika: string
  opis: string
  dobavljac: Dobavljac
  kategorija: Kategorija
}

export interface Dobavljac {
  id: number
  naziv: string
}

export interface Kategorija {
  id: number
  naziv: string
}

