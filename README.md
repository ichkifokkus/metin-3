# Fantasy Online (Arbeitstitel)

Ein Third-Person-Fantasy-Online-RPG für Windows-PC, entwickelt mit Unity und C#.

> Hinweis: Der Name des Repositorys ist ein interner Arbeitsname. Vor jeder
> Veröffentlichung wird ein eigener, markenrechtlich geprüfter Name gewählt.

## Aktueller Status

**Phase 1 – lokaler Prototyp, in Arbeit.**

| Bereich | Status |
|---|---|
| Unity-Projekt (`Game/`) | noch nicht angelegt |
| Third-Person-Bewegung und Kamera | Skripte geschrieben, **nicht getestet** |
| Kampf und Loot | geplant |
| Multiplayer | geplant |

## Ordner

| Ordner | Inhalt |
|---|---|
| `docs/` | Vision, Entscheidungen, Roadmap, Einrichtungsanleitung |
| `UnityImport/` | vorbereitete Skripte, die einmalig in `Game/Assets` kopiert werden |
| `Game/` | das Unity-Projekt (wird mit dem Unity Hub angelegt) |

## Geplante Technik

- **Engine:** Unity 6.3 LTS
- **Sprache:** C#
- **Netzwerk (Empfehlung, noch nicht bestätigt):** Netcode for GameObjects

## Einrichtung und Test

Schritt-für-Schritt-Anleitung: [`docs/SETUP_GUIDE.md`](docs/SETUP_GUIDE.md)

Steuerung im Prototyp: **WASD** laufen, **Maus** umsehen, **Mausrad** zoomen,
**Leertaste** springen, **Esc** Mauszeiger freigeben.

## Bekannte Einschränkungen

- Die Skripte wurden ohne Unity geschrieben und sind noch nie kompiliert oder getestet worden.
- Tasten sind fest belegt; frei belegbare Tasten folgen später.
- Kein Netzwerk – reiner lokaler Prototyp.
