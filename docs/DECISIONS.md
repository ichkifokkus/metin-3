# Technische Entscheidungen

Status-Werte: **entschieden**, **vorgeschlagen** (wartet auf Bestätigung), **verworfen**.

---

## D-001 – Engine: Unity 6.3 LTS

**Status:** entschieden (2026-10-27)

- Unity 6.3 LTS ist laut Unity die aktuelle Version mit Langzeit-Support (bis Dezember 2027).
- Unity 6.0 LTS wird nicht verwendet, da ihr Support im Oktober 2026 endet.
- Die genaue Unterversion (6.3.x) wird beim Anlegen des Projekts festgehalten.
- Quelle: https://unity.com/releases/unity-6

## D-002 – Render-Pipeline: Universal Render Pipeline (URP)

**Status:** entschieden (2026-10-27)

- Vorlage „Universal 3D“. Gute Leistung auf vielen PCs, Standard für neue Unity-Projekte.

## D-003 – Eingabe: Unity Input System

**Status:** entschieden (2026-10-27)

- Die Skripte lesen Tastatur und Maus über das *Input System*-Paket (`UnityEngine.InputSystem`).
- **Annahme (noch nicht geprüft):** Die Vorlage „Universal 3D“ in Unity 6.3 enthält das Input System bereits
  und hat es aktiviert. Falls nicht, zeigt Unity beim Import Fehler – dann wird das Paket über den Package Manager ergänzt.
- Frei belegbare Tasten sind geplant, aber noch nicht umgesetzt (Tasten sind vorerst fest: WASD, Leertaste, Maus).

## D-004 – Netzwerk-Stack: Netcode for GameObjects

**Status:** vorgeschlagen – wartet auf Bestätigung des Besitzers. Umsetzung erst in Phase 3.

| Kandidat | Vorteile | Nachteile |
|---|---|---|
| **Netcode for GameObjects** (Unity) | offiziell, dokumentiert, dedizierte Server, passt zu Unity-Hosting/Relay | auf kleinere Spielerzahlen pro Instanz ausgelegt |
| Mirror (Open Source) | ausgereift, große Community | kein Unity-Produkt, Erweiterungsqualität schwankt |
| FishNet (Open Source) | gilt als leistungsstark, eingebaute Vorhersage | kleinere Community |

**Begründung:** Für einen Einsteiger ist ein offizielles, gut dokumentiertes Paket mit Dedicated-Server-Unterstützung
das geringste Risiko. Zonen-/Instanz-Architektur hält die Spielerzahl pro Server klein genug.

**Offen:** Angaben zu Mirror und FishNet stammen nur aus Drittquellen und müssen vor der endgültigen Entscheidung
anhand der offiziellen Projektseiten geprüft werden. Lizenz- und Hostingkosten sind noch nicht verglichen.

## D-005 – Projektstruktur: Unity-Projekt im Unterordner `Game/`

**Status:** entschieden (2026-10-27)

- Repository-Wurzel: Dokumentation (`README.md`, `docs/`, `CHANGELOG.md`).
- `Game/`: das Unity-Projekt. Später können z. B. Backend-Dienste in eigene Ordner daneben.
- `.gitignore` schließt die von Unity erzeugten Ordner unter `Game/` aus.
