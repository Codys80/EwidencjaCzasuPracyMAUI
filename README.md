# Opis aplikacj
Aplikacja służy do rejestrowania czasu rozpoczęcia i zakończenia pracy pracownika oraz wyświetlania informacji o frekwencji i zadaniach dnia.

## Elementy aplikacji
### Na stronie głównej aplikacji należy umieścić następujące elementy:
* napis o treści: „Ewidencja czasu pracy”,
* napis o treści: „Czas rozpoczęcia:”,
* przycisk o treści: „Zarejestruj wejście”,
* napis o treści: „Czas zakończenia:”,
* przycisk o treści: „Zarejestruj wyjście”,
* napis o treści: „Frekwencja: ”,
* wskaźnik postępu (ProgressBar) pokazujący procent obecności,
* lista zadań dnia (np. w formie ListView lub CollectionView) z przykładowymi pozycjami:
  - „Spotkanie zespołu 10:00–11:00”
  - „Analiza projektu 12:00–14:00”
  - „Testy funkcjonalne 15:00–16:00”
 
## Działanie aplikacji

* Po uruchomieniu aplikacji pola Czas rozpoczęcia i Czas zakończenia są puste.
* Po naciśnięciu przycisku „Zarejestruj wejście”:
* w polu obok napisu Czas rozpoczęcia pojawia się aktualna godzina systemowa w formacie HH:mm.
* wartość wskaźnika frekwencji (ProgressBar) zwiększa się o 10%.
* Po naciśnięciu przycisku „Zarejestruj wyjście”:
* w polu obok napisu Czas zakończenia pojawia się aktualna godzina systemowa w formacie HH:mm.
* wartość wskaźnika frekwencji zwiększa się o kolejne 10%.
* Po osiągnięciu wartości 100% (pełna obecność) wskaźnik frekwencji zmienia kolor na zielony.
 
## Założenia projektu
* Interfejs użytkownika należy zapisać w języku XAML.
* Układ strony: StackLayout (lub inny liniowy).
* Marginesy strony: 20.
* Wszystkie elementy powinny być rozciągnięte na szerokość strony (HorizontalOptions="Fill").
* Kolor tła strony: #E3F2FD.
* Kolor tła przycisków: #1976D2.
* Kolor tekstu: biały dla przycisków, czarny dla pozostałych napisów.
* Napis „Ewidencja czasu pracy” powinien mieć największy rozmiar czcionki i być pogrubiony.
* Wskaźnik postępu powinien mieć wysokość min. 20 pikseli.
* Czas powinien być pobierany z systemu przy użyciu klasy DateTime.
* Kod źródłowy powinien być czytelny i odpowiednio sformatowany, z zastosowaniem znaczących nazw zmiennych i metod.
 
