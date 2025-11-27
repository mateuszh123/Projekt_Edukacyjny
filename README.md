ETAP I

1. Sklonuj projekt z github i wejdz do katalogu projektu
git clone adres_repozytorium
cd /nazwa_repozytorium

2. Uruchom Docker compose

3. sprawdz uruchomione kontenery
sudo docker-compose ps

4. Jesli nie ma zadnych kontenerow na liscie, zbuduj projekt
sudo docker-compose build

5. Uruchom w tle serwisy zaimplementowane w Docker Compose - API i DB
sudo docker-compose up -d

ETAP II
1. Podlaczenie bazy danych do PostgreSQL i utworzenie tabeli wraz z kolumnami

1) Zaloguj sie do kontenera z PostgreSQL
sudo docker-compose exec db psql -U demo -d demo

2) Utworz tabele w bazie danych
CREATE TABLE "Todos" (
  "Id" SERIAL PRIMARY KEY,
  "Title" TEXT NOT NULL,
  "IsDone" BOOLEAN NOT NULL,
  "CreatedAt" TIMESTAMPTZ NOT NULL
);

3) Dodaj dodatkową kolumne na priorytet
ALTER TABLE "Todos" ADD COLUMN "Priority" INT DEFAULT 1;

4) Wyloguj się z bazy danych i kontenera /q