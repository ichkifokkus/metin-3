# Roadmap

Zeitangaben werden erst nach dem ersten funktionierenden Prototyp gemacht.

| Phase | Inhalt | Gate (erst dann weiter) | Status |
|---|---|---|---|
| 0 | Projekt prüfen, Unity-Version, Netzwerk-Vergleich, Architektur | Besitzer versteht die Auswahl | **fast fertig** – Netzwerk-Empfehlung wartet auf Bestätigung |
| 1 | Lokaler Third-Person-Prototyp: Testszene, Bewegung, Kamera, Kollision | Projekt öffnet, startet, ist zuverlässig testbar | **in Arbeit** – Skripte geschrieben, nicht in Unity getestet |
| 2 | Kampf und Loot: ein Monster, Angriff, Tod, Loot, XP | Kernschleife wiederholbar, Fehler dokumentiert | geplant |
| 3 | Multiplayer: Netzwerk-Paket, 2 Clients + dedizierter Testserver, Serverautorität | Mehrere Clients erleben dieselben Ereignisse | geplant |
| 4 | Kleines MMORPG-Segment: Dorf, Außengebiet, Quest, Inventar, Speicherung, Gruppenboss | Externer Tester schafft den Ablauf ohne Hilfe | geplant |
| 5 | Closed Playtest | Tester verstehen den Loop, ein Teil kommt freiwillig zurück | geplant |
| 6 | Alpha und Community | Stabile, wiederholbare Builds | geplant |
| 7 | Weitere Modi (Survival, dann MOBA 3v3) | nur nach Nachweis von Spaß und Stabilität | geplant |
| 8 | Veröffentlichung und Live-Betrieb | keine kritischen Sicherheits-/Datenverlust-Probleme | geplant |

## Phase 1 im Detail

- [x] Bewegungsskript `PlayerMovement` (WASD relativ zur Kamera, Springen, Schwerkraft) – geschrieben
- [x] Kameraskript `ThirdPersonCamera` + `CameraProfile` (Maus, Zoom, Kollision) – geschrieben
- [ ] Unity-Projekt `Game/` angelegt (Besitzer, siehe `docs/SETUP_GUIDE.md`)
- [ ] Testszene gebaut
- [ ] Testtabelle aus der Anleitung im Editor durchgespielt
- [ ] Gefundene Fehler behoben

## Offene Risiken

- Netzwerk-Architektur ist noch nicht festgelegt; dauerhafte Spiellogik (Kampf, Loot) erst danach serverautoritativ bauen.
- Der Repository-Name „metin-3“ erinnert an eine bestehende Marke; vor jeder Veröffentlichung eigenen Namen wählen.
- Der Code wurde in einer Cloud-Umgebung ohne Unity geschrieben und daher noch nie kompiliert.
