´´´mermaid
@startuml

enum DruckerTyp {
  LASERDRUCKER
  FARB_LASERDRUCKER
  TINTENSTRAHLDRUCKER
}

class Drucker {
  - anzahlAusdrucke : int
  - typ : DruckerTyp
  + drucke() : void
}

class Arbeitsplatz {
  - bezeichnung : String
}

abstract class Mitarbeiter {
  - vorname : String
  - nachname : String
  - grundlohn : double
  + drucke() : void
  + berechneLohn() : double
}

class Lehrling extends Mitarbeiter {
  - lehrjahr : int
  + berechneLohn() : double
}

class Leiter extends Mitarbeiter {
  + berechneLohn() : double
}

class Abteilung {
  - name : String
}

Arbeitsplatz "1" --> "0..1" Drucker
Arbeitsplatz "1" --> "1" Mitarbeiter
Mitarbeiter "n" --> "1" Abteilung

@enduml
´´´
