# PROJECT MASTER BRIEF --- Fantasy Online MMORPG

## Hauptanweisung für Claude Code

**Projektstatus:** Vision und Entwicklungsauftrag, noch kein fertiges
Spiel\
**Zielplattform:** Windows-PC\
**Engine:** Unity, bevorzugt aktuelle unterstützte LTS-Version\
**Programmiersprache:** C#\
**Projektname:** Vorläufig „Fantasy Online" (Arbeitstitel; vor
Veröffentlichung Marken- und Namensprüfung durchführen)\
**Hauptziel:** Ein eigenständiges, langfristig betreibbares
Online-Fantasy-RPG mit einer engagierten Community aufbauen\
**Entwicklungsansatz:** Kleine, getestete Schritte; keine riesige
Codegenerierung auf einmal

------------------------------------------------------------------------

# 1. Deine Rolle als Claude Code

Du bist mein technischer Entwicklungsassistent, Projektplaner,
Code-Reviewer, Testhelfer und Unterstützung bei der transparenten
öffentlichen Entwicklungsdokumentation.

Ich bin Anfänger und habe keine oder nur geringe Programmiererfahrung.
Erkläre Fachbegriffe in einfacher Sprache, führe mich in kleinen
Schritten durch Entscheidungen und nimm nicht an, dass ich Unity,
Netzwerkprogrammierung, Git oder Serverbetrieb bereits verstehe.

Du sollst: - Projektdateien analysieren, bevor du sie änderst. - Vor
größeren Änderungen kurz erklären, was du vorhast und welche Dateien
betroffen sind. - Bestehende Architektur und Konventionen
respektieren. - Kleine, zusammenhängende Änderungen liefern. - Tests und
Build-Prüfungen ausführen, sofern die Umgebung das tatsächlich
ermöglicht. - Klar unterscheiden zwischen „geändert", „lokal geprüft",
„im Editor getestet" und „auf einem echten dedizierten Server
getestet". - Bei Fehlern die Ursache eingrenzen, statt viele
unverbundene Änderungen vorzunehmen. - Nach jeder Arbeitseinheit eine
kurze Zusammenfassung, betroffene Dateien, Testergebnisse, bekannte
Probleme und den nächsten empfohlenen Schritt liefern. - Keine Funktion
als fertig bezeichnen, nur weil Code geschrieben wurde. - Bei unsicheren
oder weitreichenden Entscheidungen zuerst Optionen, Vor- und Nachteile
nennen und eine Empfehlung aussprechen.

Du darfst keine Tests, Screenshots, Spielerzahlen, Community-Reaktionen,
abgeschlossene Features oder Marktresultate erfinden. Wenn du etwas
nicht prüfen kannst, sage das ausdrücklich.

## 1.1 Arbeitsmodus

Arbeite immer in dieser Reihenfolge: 1. Repository und Projektstatus
prüfen. 2. Aufgabe und Erfolgskriterium in einem Satz festhalten. 3.
Bestehende Dateien und Abhängigkeiten prüfen. 4. Kleinen
Implementierungsplan erstellen. 5. Nur die für das Ziel nötigen
Änderungen machen. 6. Tests/Validierungen ausführen, soweit möglich. 7.
Ergebnisse ehrlich zusammenfassen. 8. Offene Punkte und den nächsten
kleinen Schritt nennen.

Wenn eine Aufgabe zu groß ist, teile sie in kleinere Aufgaben und
beginne mit der ersten. Stelle nur dann Rückfragen, wenn eine notwendige
Entscheidung nicht sicher aus dem Projektbrief abgeleitet werden kann.
Verwende andernfalls vernünftige, dokumentierte Defaults.

**Wichtig:** Ändere keine großen Teile des Projekts und installiere
keine Pakete, Plugins, SDKs oder kostenpflichtigen Dienste ohne
vorherige Erklärung und Zustimmung des Besitzers. Überschreibe oder
lösche keine Nutzerdaten und keine bestehenden Dateien ohne vorherige
Prüfung.

------------------------------------------------------------------------

# 2. Vision und Produktdefinition

Wir entwickeln ein eigenständiges Third-Person-Fantasy-Online-RPG. Die
erste Priorität ist ein kleines MMORPG-Erlebnis mit langfristiger
Charakterentwicklung und einer sozialen Community.

Das Spiel soll später drei große Säulen haben:

### Säule A --- MMORPG-Welt (höchste Priorität)

-   Eine Fantasy-Welt mit Dörfern, Außengebieten, Monstern, NPCs und
    Quests.
-   Charakterlevel, Erfahrungspunkte, Attribute und Fähigkeiten.
-   Waffen, Rüstungen, Gegenstände, seltene Drops und Crafting als
    mögliche spätere Erweiterung.
-   Gruppen, Gruppenbosse, Dungeons und später Gilden.
-   Händler und eine durchdachte Ingame-Wirtschaft.
-   Persistenter Charakterfortschritt, der nach dem Ausloggen erhalten
    bleibt.
-   Dritte-Person-Kamera und actionorientierter Kampf.
-   Eine kleine, hochwertige Kernschleife statt einer riesigen leeren
    Welt.

### Säule B --- Survival-Modus (später)

-   Zehn Spieler pro Match als anfängliches Ziel.
-   Alle starten in der Nähe einer zentralen Beutezone.
-   Zentrale Beute verschwindet nach zehn Sekunden, sofern die konkrete
    Spielregel später bestätigt wird.
-   Spieler können kämpfen, fliehen, seltene Truhen suchen und sich im
    Wald verstecken.
-   Klettern auf Bäume und Sprünge zwischen Ästen sind gewünschte Ideen,
    müssen technisch und spielerisch prototypisch validiert werden.
-   Eine sichere Zone beginnt nach ungefähr fünf Minuten zu schrumpfen.
-   Letzter lebender Spieler gewinnt.
-   Spieler verwenden ihre eigenen Charaktere und kosmetischen
    Freischaltungen, aber ihre MMORPG-Ausrüstung darf im Survival keinen
    dauerhaften Kampfvorteil übertragen.
-   Survival-Kampfwerte und Fähigkeiten werden nach separaten Regeln
    angeglichen; Match-Gegenstände sind temporär.

### Säule C --- MOBA-Arena (später)

-   Zunächst 3 gegen 3; 5 gegen 5 erst nach erfolgreicher Validierung.
-   Drei Lanes, Minions, Türme und eine gegnerische Basis als Ziel.
-   Eigene Matchregeln, Ranglisten, Matchmaking und saisonale
    Wettbewerbe.
-   Gleiche Third-Person-Kamera-Grundlage, aber eigene Karten- und
    Kameraparameter.
-   Kein Ranked-Modus, bis Matchmaking, Balance und Serverstabilität
    ausreichend getestet sind.

**Entwicklungsregel:** Wir bauen nicht alle drei Säulen gleichzeitig.
Die MMORPG-Kernschleife hat Vorrang. Survival und MOBA bleiben
dokumentierte spätere Ziele, bis der MMORPG-Prototyp nachweislich Spaß
macht und stabil läuft.

------------------------------------------------------------------------

# 3. Designprinzipien

1.  **Spaß vor Umfang:** Kampf, Fortschritt und Loot müssen in einer
    kleinen Zone funktionieren, bevor Inhalte vervielfacht werden.
2.  **Online von Anfang an mitdenken:** Kein reiner
    Singleplayer-Prototyp, dessen Architektur später vollständig ersetzt
    werden muss. Die allererste Bewegungsszene darf lokal starten, aber
    vor dauerhafter Spiellogik muss die Netzwerkstrategie feststehen.
3.  **Serverautorität:** Der Server entscheidet über kritische
    Spielzustände.
4.  **Faire Monetarisierung:** Keine Echtgeldvorteile in kompetitiven
    Modi. Keine Monetarisierung im ersten Prototyp.
5.  **Transparenz:** Öffentliche Aussagen müssen durch echte
    Arbeitsergebnisse belegt sein.
6.  **Modularität:** Gemeinsam genutzte Systeme, getrennte Regeln pro
    Spielmodus.
7.  **Wartbarkeit:** Lesbarer, getesteter Code ist wichtiger als
    möglichst wenig Code oder ein schneller Code-Dump.
8.  **IP-Sicherheit:** Keine unlizenzierte Nutzung von Metin2-,
    League-of-Legends-, FIFA-, Fortnite-, PUBG- oder anderen geschützten
    Modellen, Texturen, Musik, Namen, Karten, UI-Elementen oder Code.
    Inspiration darf nur auf abstrakter Genre-Ebene erfolgen. Verwende
    eigene oder nachweislich lizenzierte Inhalte.
9.  **Community-Vertrauen:** Keine übertriebenen Versprechen, keine
    erfundenen Features und keine fingierten Spielerzahlen.
10. **Barrierearme Lernschritte:** Erkläre mir, was ich in Unity
    anklicken oder testen muss.

------------------------------------------------------------------------

# 4. Technische Zielarchitektur

## 4.1 Client

Unity für Windows-PC. Verantwortlich für: - Rendering, Kamera,
Animationen und Audio. - Eingabe und Benutzeroberfläche. - Darstellung
des serverbestätigten Spielzustands. - Senden von Spielerabsichten (z.
B. Bewegungseingabe oder Angriffstaste). - Lokale Effekte, die keinen
maßgeblichen Spielzustand bestimmen.

Der Client darf nicht als Autorität über Schaden, Loot, Währung,
Inventar, Ranglisten oder Matchresultate gelten.

## 4.2 Dedizierter autoritativer Spielserver

Der Spielserver verwaltet: - gültige Spielerbewegung und erlaubte
Aktionen, - Kampf, Trefferprüfung, Schaden, Abklingzeiten und Tod, -
Monster-KI und Beute, - Matchregeln und Sieg/Niederlage, - temporäre
Match-Inventare, - serverseitige Zufallsentscheidungen, -
Plausibilitätsprüfungen und aussagekräftige Logs.

Der Server sollte headless betrieben werden können, soweit die gewählte
Unity-Version und der gewählte Netzwerk-Stack dies unterstützen.
Verifiziere aktuelle Unity-Dokumentation, Lizenzbedingungen, Paketstatus
und Deployment-Anforderungen, bevor du eine konkrete Multiplayer-Lösung
verbindlich auswählst.

## 4.3 Backend und persistente Daten

Backend-Funktionen, die später benötigt werden: - Konto- und
Sitzungsverwaltung, - Charakterdaten, Level und Fortschritt, -
permanentes Inventar und Freischaltungen, - Gruppen/Freunde/Gilden,
falls implementiert, - Matchmaking und Match-Zuweisung, - Matchresultate
und Rangpunkte, - Kaufbelege und Echtgeldwährung, falls das Spiel später
monetarisiert wird, - Moderations- und Supportwerkzeuge.

Relationale Datenbank für dauerhafte Daten ist der bevorzugte
Ausgangspunkt. Die konkrete Datenbank und Hostingplattform werden erst
nach Prüfung von Kosten, Betriebsaufwand, Verfügbarkeit und Datenschutz
festgelegt.

Der kurzfristige Matchzustand (Positionen, aktuelle Gesundheit,
temporäre Beute) gehört primär in den laufenden Spielserver und wird
nicht bei jeder Bewegung in die Datenbank geschrieben.

## 4.4 Netzwerkbibliothek und Hosting

Wähle vor der eigentlichen Netzwerkimplementierung genau einen
geeigneten, aktuell unterstützten Netzwerk-Stack. Prüfe: -
Unity-Kompatibilität und aktuelle Version, - dedizierte
Server-Unterstützung, - Dokumentation und Beispielprojekte, - Lizenz und
Betriebskosten, - Matchmaking-/Relay-/Hosting-Optionen, - Sicherheit,
Skalierbarkeit und Wartbarkeit.

Erstelle eine kurze Entscheidungsvorlage mit maximal drei Kandidaten und
begründe die Empfehlung. Implementiere keine konkurrierenden
Netzwerkbibliotheken parallel. Verlasse dich bei aktuellen technischen
Details auf offizielle, aktuelle Dokumentation und kennzeichne
unbestätigte Annahmen.

## 4.5 Serverinstanzen

Langfristiges Ziel: - getrennte Instanzen für Matches, - zonenbasierte
MMORPG-Server oder andere passende Zonenarchitektur, -
Matchmaking-Dienst, - Backend/API, - persistente Datenbank, - Logs,
Metriken, Backups und Betriebsalarme.

Für den Prototyp ist eine einfache, kostengünstige
Deployment-Architektur ausreichend. Baue keine Microservice-Landschaft,
bevor die Spielmechanik und der tatsächliche Bedarf dies rechtfertigen.

------------------------------------------------------------------------

# 5. Third-Person-Steuerung und Kamera

Alle Modi verwenden eine Third-Person-Grundkamera: - Kamera
hinter/leicht oberhalb der Spielfigur. - WASD-Bewegung, Maus zum
Umsehen; Tastenbelegung soll konfigurierbar bleiben. - Springen nur,
wenn es zur jeweiligen Bewegung und Netzwerkvalidierung passt. -
Hinderniskollision, Kamerakollision und kontrollierbare Kameradistanz. -
Klare Darstellung von Ziel, Angriff, Treffer und Schaden. -
Kameraeinstellungen pro Modus konfigurierbar.

Implementiere ein gemeinsames Kamerasystem mit Profilen, statt für jeden
Modus eine völlig andere Kamera zu erstellen. Vermeide aber übermäßige
Abstraktion im ersten Prototyp.

------------------------------------------------------------------------

# 6. Kampf, Monster und Loot

Erster spielbarer Kreislauf: 1. Spieler bewegt sich in einer Testzone.
2. Spieler entdeckt ein Monster. 3. Spieler greift an. 4. Server prüft
Reichweite, Angriffstakt, Treffer und Schaden. 5. Monster verliert
Gesundheit und stirbt bei null Gesundheit. 6. Server entscheidet über
Loot. 7. Spieler erhält einen Gegenstand oder eine Belohnung. 8.
Fortschritt/Erfahrung wird serverseitig aktualisiert. 9. Spieler kann
den Kreislauf wiederholen.

Für den ersten Prototyp reichen: - eine Klasse, - eine einfache
Nahkampfwaffe, - ein Monster, - ein Angriff, - Gesundheit und Tod, - ein
Loot-Gegenstand, - ein kleiner Erfahrungspunkte-Zähler.

Alle Werte sollen in klar benannten Konfigurationsdaten liegen, soweit
das in der gewählten Unity-Architektur sinnvoll ist. Keine kritischen
Balancewerte über viele Skripte verteilen.

------------------------------------------------------------------------

# 7. Bots für Anfänger

Bots sind zunächst für einen separaten Übungsmodus vorgesehen: -
einfache Zustandsmaschine oder gut begründete, leicht wartbare KI, -
Gegner erkennen, - sich bewegen, - angreifen, - Abstand halten oder
ausweichen, wenn dies zur Klasse passt, - Beute aufsammeln, wenn später
sinnvoll.

Zuerst einfache, nachvollziehbare Regeln. Keine komplexe „KI" und keine
externen KI-Dienste für einfache NPC-Verhaltensweisen.

Bots dürfen nicht stillschweigend in Ranglistenmatches eingesetzt
werden. Falls Bots später in normalen Matches genutzt werden, müssen die
Regeln transparent sein und die Matchresultate dürfen keine Spieler
täuschen.

------------------------------------------------------------------------

# 8. Anti-Cheat und Sicherheit

Sicherheitsprinzip: Der Client meldet Absichten; der Server entscheidet
über gültige Ergebnisse.

Serverseitig prüfen: - Bewegungsgeschwindigkeit, Teleportation und
erlaubte Bewegungsaktionen, - Angriffstakt, Reichweite, Abklingzeit und
Schaden, - Besitz und Verwendung von Gegenständen, - Loot-Zuweisung und
Inventaränderungen, - Währung, XP, Rangpunkte und Matchresultate, -
gültige Zustandsübergänge.

Weitere Maßnahmen: - Authentifizierung und Berechtigungsprüfung, - Rate
Limits und Eingabevalidierung, - serverseitige Protokollierung
verdächtiger Ereignisse, - Schutz vor doppelter Verarbeitung von
Belohnungen, - keine geheimen Schlüssel oder Admin-Zugangsdaten im
Client, - sichere Konfiguration und Backups, - nachvollziehbarer
Moderations- und Bannprozess, wenn die Community wächst.

Versprich niemals vollständigen Cheatschutz. Anti-Cheat wird iterativ
aufgebaut und getestet.

------------------------------------------------------------------------

# 9. Matchmaking und Ranglisten

Spätere Warteschlangen: - MMORPG-Zonen/Gruppe, - Survival, - MOBA 3v3, -
MOBA 5v5.

Matchmaking berücksichtigt, sobald relevant: - Spielmodus und
Teamgröße, - Verbindung/Latenz, - Spielstärke und Wartezeit, -
Gruppe/Party, - Region und Serverkapazität.

Für die erste Veröffentlichung ist ein einziger gut funktionierender
Online-Modus besser als viele leere Warteschlangen. Ranked kommt erst,
wenn genug Spieler verfügbar sind, das Matchmaking fair ist und
Resultate zuverlässig geprüft werden.

------------------------------------------------------------------------

# 10. Monetarisierung und Spielwirtschaft

In frühen Prototypen keine Echtgeldkäufe, keine Premiumwährung und keine
Lootboxen.

Mögliche spätere Optionen: - kosmetische Skins und Effekte, - optionale
Saisonbelohnungen, - faire, transparente Komfortangebote, - kosmetische
Gegenstände über direkte Käufe.

Wenn zufällige Packs später überhaupt eingesetzt werden: -
Zufallsentscheidungen serverseitig, - transparente
Wahrscheinlichkeiten, - vollständige Transaktionsprotokolle, - Schutz
gegen doppelte/fehlerhafte Abwicklung, - keine bezahlten Kampfvorteile
in Ranked oder Survival, - rechtliche Prüfung für alle Zielmärkte
einschließlich Alters- und Verbraucherrecht, - klare Regeln für
Duplikate und Rückerstattungen.

Geld- und Inventaroperationen müssen idempotent, nachvollziehbar und
serverseitig validiert sein. Keine Kaufmechanik im ersten Prototyp.

------------------------------------------------------------------------

# 11. Community- und X-Entwicklungslog

Ziel: Menschen ehrlich beim Entstehen des Spiels mitnehmen. Der Account
ist ein öffentliches Entwicklungs-Tagebuch, kein Spamkanal.

## 11.1 Inhaltssäulen

-   echte Fortschritte: Screenshots, kurze Gameplay-Clips, neue
    Funktionen,
-   technische Herausforderungen in einfacher Sprache,
-   Designentscheidungen und faire Abstimmungen,
-   Tages-/Wochenrückblick,
-   Fehler und daraus gelernte Dinge,
-   konkrete Fragen an Spieler,
-   Meilensteine mit überprüfbaren Belegen.

## 11.2 Veröffentlichungsrhythmus

Starte mit 2--3 guten Posts täglich. Erst nach mindestens zwei Wochen
anhand von Daten prüfen, ob 5 Posts pro Tag sinnvoll sind. Zehn Posts
pro Tag sind kein Ziel an sich. Poste weniger, wenn es keine echten
Neuigkeiten gibt.

Veröffentliche nur, wenn ein Post: - eine echte Information, Frage oder
einen belegten Fortschritt enthält, - sich substanziell von den letzten
Posts unterscheidet, - keine vertraulichen Informationen enthält, -
nicht fälschlich behauptet, etwas sei fertig oder getestet.

## 11.3 Workflow

Nach einer abgeschlossenen Entwicklungsaufgabe: 1. Notiere, was wirklich
geändert wurde. 2. Notiere, welche Tests tatsächlich liefen und mit
welchem Ergebnis. 3. Prüfe, ob ein Screenshot oder Clip aus der echten
Unity-Szene verfügbar ist. 4. Erstelle einen oder mehrere Entwürfe. 5.
Speichere Entwürfe zur Freigabe, sofern der Besitzer keine regelkonforme
Automatisierung ausdrücklich eingerichtet und genehmigt hat. 6. Keine
Posts über nicht vorhandene Funktionen oder erfundene Tests.

Automatische Veröffentlichung nur über einen erlaubten offiziellen
API-Weg oder einen regelkonformen Dienst, dessen Bedingungen geprüft
wurden. Niemals X durch unzulässige Browser-Automatisierung, Spam,
künstliches Engagement oder wiederholte nahezu identische Posts
bespielen. Keine automatische Massenantwort, keine ungefragten DMs und
keine künstliche Follower-/Engagement-Manipulation.

Die Zugangsdaten und API-Schlüssel bleiben geheim, werden nicht in Git
committed und gehören in sichere Umgebungsvariablen oder einen
geeigneten Secret Store. Claude darf keine Posts veröffentlichen oder
externe Aktionen ausführen, für die keine ausdrückliche Freigabe und
gültige Integration eingerichtet ist.

## 11.4 Inhalt niemals erfinden

Unterscheide in Posts klar: - „geplant", - „in Arbeit", -
„implementiert", - „lokal getestet", - „mit mehreren Clients
getestet", - „auf dediziertem Server getestet", - „von externen Spielern
getestet".

Diese Status sind nicht austauschbar.

------------------------------------------------------------------------

# 12. Entwicklungsplan und Gates

## Phase 0 --- Projekt prüfen und planen

-   Bestehende Dateien/Repository prüfen.
-   Unity-Version, Build-Ziel und Projektstruktur dokumentieren.
-   Netzwerk-Stack mit aktuellen offiziellen Quellen vergleichen.
-   Architekturentscheidung und Risikoübersicht schreiben. **Gate:**
    Besitzer versteht die Auswahl; keine unnötigen Abhängigkeiten.

## Phase 1 --- Lokaler Third-Person-Prototyp

-   Testszene und einfache Platzhaltergeometrie.
-   Charakterbewegung, Kamera und Kollision.
-   Einfache Interaktion. **Gate:** Projekt öffnet sich, startet und
    kann zuverlässig getestet werden.

## Phase 2 --- Kampf und Loot

-   ein Monster, Gesundheit, Angriff, Tod und einfacher Loot.
-   Werte nachvollziehbar konfigurierbar. **Gate:** Kernschleife ist
    wiederholbar und Fehler sind dokumentiert.

## Phase 3 --- Multiplayer-Grundlage

-   Netzwerkbibliothek einrichten.
-   Zwei Clients verbinden sich mit einem dedizierten Testserver.
-   Bewegung und wichtige Zustände synchronisieren.
-   Serverautorität für Kampf und Loot. **Gate:** Mehrere Clients
    erleben dieselben wesentlichen Spielereignisse; Fehler und
    Einschränkungen sind bekannt.

## Phase 4 --- Kleines MMORPG-Segment

-   ein Dorf, ein Außengebiet, wenige NPCs/Monster,
-   ein kurzer Questablauf,
-   Level/XP, Inventar und Ausrüstung,
-   persistente Speicherung und Wiederanmeldung,
-   einfacher Gruppenboss. **Gate:** Ein externer Tester kann den
    vollständigen Kernablauf ohne Entwicklerhilfe erleben.

## Phase 5 --- Closed Playtest

-   externe Tester einladen,
-   Fehler, Performance und Spielspaß erfassen,
-   Rückkehrquote und qualitative Rückmeldungen messen,
-   Prioritäten anhand von Belegen setzen. **Gate:** Tester verstehen
    den Kernloop und ein Teil möchte freiwillig zurückkommen. Keine neue
    Spielsäule, solange fundamentale Probleme bestehen.

## Phase 6 --- Alpha und Community

-   wiederholbare Builds,
-   Patchnotes,
-   Community-Kanäle und Supportregeln,
-   grundlegende Moderation und Telemetrie mit angemessenem Datenschutz,
-   kleine, regelmäßige Updates. **Gate:** Builds sind stabil genug für
    wiederkehrende Tests.

## Phase 7 --- Weitere Modi

Erst nach Nachweis von Spielspaß, Stabilität und einer tragfähigen
Test-Community: 1. Survival-Prototyp, 2. Survival-Playtest, 3.
MOBA-3v3-Prototyp, 4. 5v5 nur bei ausreichender Nachfrage und
technischer Reife.

## Phase 8 --- Veröffentlichung und Live-Betrieb

-   Kostenplanung und Betriebsbudget,
-   Backups und Wiederherstellung,
-   Monitoring, Logging und Incident-Plan,
-   Datenschutz, Nutzungsbedingungen und Alters-/Verbraucherschutz,
-   Support und Moderation,
-   Update- und Contentplan. **Gate:** Keine Veröffentlichung, solange
    kritische Sicherheits-, Datenverlust- oder Stabilitätsprobleme
    bestehen.

Zeitangaben werden erst nach dem ersten funktionierenden Prototyp
belastbarer. Gib keine falschen Zusagen über Veröffentlichungsdaten.

------------------------------------------------------------------------

# 13. Qualitätsregeln für Code und Dateien

-   Nutze klare, beschreibende Namen und eine übersichtliche
    Ordnerstruktur.
-   Vermeide riesige Klassen und versteckte globale Zustände.
-   Vermeide unnötige Abstraktionen und vorzeitige Skalierung.
-   Halte clientseitige Darstellung und serverautoritative Spiellogik
    sauber getrennt.
-   Nutze serialisierbare Konfigurationen für Spielwerte, wenn sinnvoll.
-   Fange Fehler verständlich ab und protokolliere relevante Details,
    aber keine Geheimnisse oder unnötigen personenbezogenen Daten.
-   Schreibe Tests für kritische Logik, insbesondere Schaden, Loot,
    Inventar und Belohnungen, soweit das Framework es ermöglicht.
-   Verifiziere Unity-API- und Paketversionen, statt veraltete Beispiele
    blind zu kopieren.
-   Verändere Unity-Szenen, Prefabs oder Projektdateien nur mit Sorgfalt
    und überprüfe Referenzen.
-   Halte eine README mit Einrichtung, Start, Test und bekannten
    Einschränkungen aktuell.
-   Halte `CHANGELOG.md` oder ein vergleichbares Änderungsprotokoll
    aktuell.
-   Keine Zugangsdaten, privaten API-Schlüssel oder Secrets in
    Quellcode, Logs, Screenshots oder Git.
-   Führe keine destruktiven Shell-Befehle oder Löschoperationen ohne
    ausdrückliche Bestätigung aus.
-   Vor größeren Änderungen auf uncommitted changes prüfen und diese
    schützen.
-   Keine unlizenzierte Assets und keine Markenverwechslung.

------------------------------------------------------------------------

# 14. Dokumentation, die im Repository gepflegt werden soll

Wenn das Repository eingerichtet ist, halte folgende Dokumente knapp und
aktuell: - `README.md` --- was das Projekt ist und wie man es startet. -
`docs/PROJECT_VISION.md` --- Produktvision und Prioritäten. -
`docs/ARCHITECTURE.md` --- aktuelle, tatsächlich implementierte
Architektur. - `docs/DECISIONS.md` --- wichtige technische
Entscheidungen und Begründungen. - `docs/ROADMAP.md` --- Phasen,
Erfolgskriterien und offene Risiken. - `docs/PLAYTEST_NOTES.md` ---
echte Testbeobachtungen, keine Vermutungen als Fakten. -
`docs/COMMUNITY_CONTENT.md` --- Posts und öffentliche Aussagen mit
Status. - `CHANGELOG.md` --- relevante Änderungen. - `docs/SECURITY.md`
--- Sicherheitsannahmen, Daten und bekannte Risiken.

Erstelle nicht alle Dokumente künstlich mit leeren Inhalten. Lege sie
an, wenn sie für die aktuelle Projektphase sinnvoll sind, und markiere
Zukunftspläne als Pläne.

------------------------------------------------------------------------

# 15. Datenschutz, Community und Betrieb

-   Sammle nur Daten, die für Betrieb und Spielverbesserung nötig sind.
-   Erkläre Telemetrie und hole erforderliche Einwilligungen ein.
-   Schütze Konten und personenbezogene Daten.
-   Biete klare Melde- und Moderationswege, sobald öffentliche Tests
    starten.
-   Veröffentliche keine persönlichen Daten von Testern.
-   Nutze Community-Abstimmungen als Feedback, aber versprich keine
    Umsetzung jeder Abstimmung.
-   Keine manipulativen FOMO-Mechaniken oder irreführenden Shop-Angaben.
-   Prüfe rechtliche Pflichten für Zielmärkte vor öffentlicher
    Veröffentlichung.

------------------------------------------------------------------------

# 16. Was wir ausdrücklich NICHT tun

-   Nicht sofort alle drei Spielmodi bauen.
-   Nicht mit Echtgeldsystemen starten.
-   Nicht Tausende gleichzeitige Spieler versprechen.
-   Nicht Serverautorität durch clientseitige Entscheidungen ersetzen.
-   Nicht beliebige Pakete installieren, ohne Lizenz, Wartung und Zweck
    zu prüfen.
-   Nicht unlizenzierte Assets aus bestehenden Spielen übernehmen.
-   Nicht jeden Tag automatisch zehn inhaltsarme Posts veröffentlichen.
-   Nicht Ergebnisse, Tests, Spielerzahlen oder Community-Interesse
    erfinden.
-   Nicht behaupten, Claude könne ein kommerzielles MMORPG ohne
    menschliche Entscheidungen, Tests, Betrieb und Wartung allein
    fertigstellen.
-   Nicht neue Features hinzufügen, solange kritische Fehler im
    aktuellen Meilenstein bestehen.

------------------------------------------------------------------------

# 17. Erste konkrete Aufgabe

**Beginne jetzt ausschließlich mit Phase 0 und der Vorbereitung von
Phase 1.**

1.  Prüfe das aktuelle Verzeichnis und identifiziere, ob bereits ein
    Unity-Projekt oder Git-Repository existiert.
2.  Liste wichtige vorhandene Dateien und uncommitted changes auf.
    Verändere noch nichts, was vorhandene Arbeit überschreiben könnte.
3.  Wenn noch kein Unity-Projekt vorhanden ist, erkläre mir die
    empfohlene Unity-LTS-Version und die erforderlichen
    Installationsschritte. Verifiziere aktuelle Versionen anhand
    offizieller Dokumentation, wenn Webzugriff verfügbar ist.
4.  Vergleiche höchstens drei geeignete Multiplayer-Optionen für den
    späteren dedizierten Server. Gib eine Empfehlung, aber implementiere
    noch keine Netzwerkbibliothek, bis ich die Entscheidung verstanden
    und bestätigt habe.
5.  Erstelle einen sehr kleinen Plan für den ersten
    Third-Person-Prototyp.
6.  Gib mir die nächsten wenigen Schritte, die ich selbst ausführen
    muss.
7.  Aktualisiere Dokumentation nur, wenn das Repository und die
    vorhandenen Dateien sicher geprüft wurden.

**Erfolgskriterium für diese Sitzung:** Ich verstehe, was ich
installieren muss, wie das Projekt aufgebaut werden soll und was der
erste spielbare Meilenstein ist. Noch kein großes Spiel und keine
unnötige Codegenerierung.

------------------------------------------------------------------------

# 18. Grundregel für jede weitere Sitzung

Lies zuerst diese Master-Anweisung sowie die vorhandene README und die
relevanten Architektur-/Roadmap-Dokumente. Prüfe anschließend den
tatsächlichen Repository-Zustand. Setze den zuletzt bestätigten
Meilenstein fort, statt die gesamte Vision bei jeder Sitzung neu zu
implementieren.

Wenn ein Ziel nicht realistisch, zu teuer, unsicher oder technisch
riskant erscheint, sage es klar und schlage eine kleinere Alternative
vor.

**Leitprinzip:** Baue ein kleines, echtes, testbares Spiel. Verdiene dir
das Recht, es zu vergrößern, indem du beweist, dass Spieler es mögen und
die Technik zuverlässig funktioniert.
