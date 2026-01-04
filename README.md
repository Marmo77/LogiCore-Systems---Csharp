<h1 align="center">📦 Intelligent Logistics Order Processing System</h1>

<p align="center">
  <b>Projekt edukacyjny – programowanie obiektowe (OOP)</b><br/>
  Symulacja realnego problemu biznesowego z branży logistycznej
</p>

<hr/>

<h2>📌 Opis projektu</h2>

<p>
Projekt przedstawia <b>rdzeń systemu decyzyjnego</b> wykorzystywanego w firmie logistycznej
obsługującej zamówienia e-commerce.  
System odpowiada za <b>inteligentne przetwarzanie zamówień</b>, wybór magazynów,
przewoźników oraz strategii realizacji.
</p>

<p>
Nie jest to aplikacja webowa ani mobilna – projekt skupia się wyłącznie na
<b>logice biznesowej</b> oraz <b>czystym modelu domenowym</b>.
</p>

---

<h2>🎯 Cel projektu</h2>

<ul>
  <li>Nauka i praktyczne zastosowanie <b>programowania obiektowego (OOP)</b></li>
  <li>Zrozumienie zasad <b>SOLID</b> w realnym kontekście</li>
  <li>Modelowanie złożonych problemów biznesowych</li>
  <li>Przygotowanie do egzaminu <b>INF.04</b></li>
  <li>Ćwiczenie myślenia projektowego jak w prawdziwej firmie IT</li>
</ul>

<p>
Projekt powstał jako <b>forma nauki poprzez symulację realnego zlecenia komercyjnego</b>,
gdzie programista otrzymuje wymagania biznesowe zamiast gotowych instrukcji.
</p>

---

<h2>🏢 Kontekst biznesowy (fikcyjny)</h2>

<p>
Firma <b>LogiCore Systems</b> tworzy systemy SaaS dla e-commerce i retail.
Klienci posiadają wiele magazynów, różne typy produktów oraz korzystają
z wielu przewoźników.
</p>

<p>
Problemem jest:
</p>

<ul>
  <li>nieoptymalny wybór magazynów</li>
  <li>zbyt wysokie koszty wysyłki</li>
  <li>brak przejrzystości procesu realizacji zamówień</li>
</ul>

<p>
Zadaniem systemu jest automatyczne podjęcie decyzji:
<b>skąd, jak i za ile</b> zrealizować zamówienie.
</p>

---

<h2>🧠 Zakres funkcjonalny</h2>

<h3>🏬 Magazyny</h3>
<ul>
  <li>unikalne ID</li>
  <li>lokalizacja (region / współrzędne)</li>
  <li>stan magazynowy produktów</li>
  <li>ograniczenia wysyłkowe (gabaryty, międzynarodowe, limity)</li>
</ul>

<h3>📦 Produkty</h3>
<ul>
  <li>waga i rozmiar</li>
  <li>typ: standardowy, kruchy, niebezpieczny</li>
  <li>możliwe wymagania specjalnego transportu</li>
</ul>

<h3>🚚 Przewoźnicy</h3>
<ul>
  <li>obsługiwane regiony</li>
  <li>własne algorytmy wyceny</li>
  <li>ograniczenia produktowe</li>
  <li>czas dostawy (SLA)</li>
</ul>

<h3>🛒 Zamówienia</h3>
<ul>
  <li>wiele produktów i ilości</li>
  <li>adres docelowy</li>
  <li>priorytet (normalny / ekspres)</li>
  <li>możliwość dzielenia na paczki</li>
</ul>

---

<h2>⚙️ Logika decyzyjna</h2>

<p>
System musi:
</p>

<ol>
  <li>zidentyfikować możliwe magazyny</li>
  <li>sprawdzić ograniczenia logistyczne</li>
  <li>wybrać strategię realizacji zamówienia</li>
  <li>dobrać przewoźników</li>
  <li>obsłużyć konflikty i sytuacje brzegowe</li>
</ol>

<p>
Decyzje podejmowane są na podstawie:
</p>

<ul>
  <li>kosztu</li>
  <li>czasu dostawy</li>
  <li>priorytetu zamówienia</li>
  <li>ograniczeń biznesowych</li>
</ul>

---

<h2>📄 Oczekiwany rezultat działania systemu</h2>

<ul>
  <li>informacja, czy zamówienie może zostać zrealizowane</li>
  <li>szczegółowy plan realizacji</li>
  <li>koszty wysyłek</li>
  <li>przewidywany czas dostawy</li>
  <li>ostrzeżenia i decyzje biznesowe</li>
</ul>

---

<h2>🧱 Wymagania techniczne</h2>

<ul>
  <li>czyste programowanie obiektowe</li>
  <li>zasady SOLID</li>
  <li>brak zależności od UI i frameworków</li>
  <li>możliwość testów jednostkowych</li>
  <li>logika domenowa oddzielona od infrastruktury</li>
</ul>

---

<h2>🚀 Dlaczego ten projekt?</h2>

<p>
Projekt został stworzony jako:
</p>

<ul>
  <li>ćwiczenie <b>realnego myślenia programistycznego</b></li>
  <li>alternatywa dla prostych CRUD-ów</li>
  <li>trening do egzaminu <b>INF.04</b> w praktycznej formie</li>
  <li>podstawa do dalszej rozbudowy (AI, strategie, optymalizacja)</li>
</ul>

<p>
To nie jest „zadanie szkolne” – to <b>symulacja prawdziwego projektu komercyjnego</b>.
</p>

---

<h2>🔮 Możliwości rozbudowy</h2>

<ul>
  <li>nowi przewoźnicy (np. drony)</li>
  <li>dynamiczne ceny</li>
  <li>strategie oparte o AI</li>
  <li>priorytety klientów VIP</li>
</ul>

---

<h2>🧑‍💻 Autor</h2>

<p>
Projekt edukacyjny tworzony w celu rozwoju umiejętności programistycznych
oraz nauki projektowania systemów obiektowych.
</p>
