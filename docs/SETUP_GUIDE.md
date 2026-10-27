# Anleitung: Projekt einrichten und ersten Prototyp testen

Diese Anleitung ist für Einsteiger geschrieben. Arbeite sie von oben nach unten durch.
Wenn ein Schritt nicht so aussieht wie beschrieben, notiere, was du siehst, und melde dich.

---

## Teil 1 – Programme installieren

1. **Unity Hub** herunterladen: https://unity.com/download – installieren, starten, kostenloses Unity-Konto anlegen.
2. Im Unity Hub links **Installs** → **Install Editor** → die neueste **Unity 6.3 LTS** wählen.
3. Bei den Modulen anhaken:
   - **Microsoft Visual Studio Community** (falls angeboten – das ist der Code-Editor)
   - **Windows Build Support (IL2CPP)**
   - **Windows Dedicated Server Build Support** (brauchen wir später für den Spielserver)
4. **GitHub Desktop** installieren: https://desktop.github.com – mit deinem GitHub-Konto anmelden.
   GitHub Desktop ist ein Programm mit Knöpfen statt Befehlen, um Änderungen zu speichern und hochzuladen.

## Teil 2 – Repository auf deinen PC holen

1. In GitHub Desktop: **File → Clone repository** → `ichkifokkus/metin-3` auswählen.
2. Als „Local path“ z. B. `C:\Projekte\metin-3` wählen → **Clone**.

Ergebnis: Auf deinem PC gibt es jetzt den Ordner `C:\Projekte\metin-3` mit `README.md`, `docs` und `UnityImport`.

## Teil 3 – Unity-Projekt anlegen

1. Im Unity Hub: **Projects → New project**.
2. Oben die Editor-Version **6.3 LTS** wählen.
3. Vorlage: **Universal 3D** (auch „3D (URP)“ genannt).
4. **Project name:** `Game` (genau so – darauf sind `.gitignore` und Anleitung abgestimmt).
5. **Location:** der Repository-Ordner, also z. B. `C:\Projekte\metin-3`.
6. **Create project** – das dauert beim ersten Mal einige Minuten.

Ergebnis: Es gibt den Ordner `C:\Projekte\metin-3\Game` mit `Assets`, `Packages`, `ProjectSettings` usw.

## Teil 4 – Skripte ins Projekt kopieren

1. Im Windows-Explorer `C:\Projekte\metin-3\UnityImport\Assets` öffnen.
2. Den Ordner **Scripts** kopieren und in `C:\Projekte\metin-3\Game\Assets` einfügen.
3. Zurück in Unity: Unity lädt die Skripte automatisch. Unten in der **Console** (Fenster → General → Console)
   sollten **keine roten Fehler** stehen.
   - Falls rote Fehler erscheinen: Text kopieren und mir schicken.
4. Den Ordner `UnityImport` brauchst du danach nicht mehr – du kannst ihn löschen (oder ich räume ihn beim nächsten Mal auf).

## Teil 5 – Testszene bauen

Unity öffnet automatisch die Szene `SampleScene`. Darin:

**Boden**
1. Im Fenster **Hierarchy** Rechtsklick → **3D Object → Plane**. Umbenennen in `Ground`.
2. Im **Inspector** bei *Transform*: Position `0, 0, 0`, Scale `5, 1, 5`.

**Hindernisse**
3. Rechtsklick → **3D Object → Cube**, ein paar Mal. Verteile sie mit dem Verschiebe-Werkzeug (Taste **W**) auf dem Boden.
   Mach einen Würfel groß (Scale z. B. `4, 3, 1`) als Wand, um die Kamerakollision zu testen.

**Spielfigur**
4. Rechtsklick → **3D Object → Capsule**. Umbenennen in `Player`. Position `0, 1, 0`.
5. Im Inspector bei der Komponente **Capsule Collider**: auf die drei Punkte ⋮ → **Remove Component**.
   (Der Character Controller bringt eine eigene Kollision mit.)
6. **Add Component** → `Character Controller` hinzufügen.
7. **Add Component** → `Player Movement` hinzufügen.
8. Optional, damit man sieht, wohin die Figur schaut: Rechtsklick auf `Player` → 3D Object → Cube,
   Position `0, 0.5, 0.5`, Scale `0.3, 0.3, 0.3` (eine kleine „Nase“). Beim Nasen-Würfel den
   **Box Collider** entfernen.

**Kamera-Profil**
9. Im **Project**-Fenster in den Ordner `Assets` gehen, Rechtsklick → **Create → Fantasy Online → Camera Profile**.
   Name: `MmorpgCameraProfile`.

**Kamera**
10. In der Hierarchy **Main Camera** anklicken → **Add Component** → `Third Person Camera`.
11. `Player` aus der Hierarchy in das Feld **Target** ziehen.
12. `MmorpgCameraProfile` aus dem Project-Fenster in das Feld **Profile** ziehen.

13. Szene speichern: **Strg + S**.

## Teil 6 – Testen

Oben auf **Play** (▶) drücken und ins Spielfenster klicken.

Prüfe diese Punkte und notiere jeweils ✅ oder ❌:

| # | Test | Erwartung |
|---|---|---|
| 1 | W / A / S / D drücken | Figur läuft vorwärts / links / rückwärts / rechts – **aus Sicht der Kamera** |
| 2 | Maus bewegen | Kamera kreist um die Figur, nach oben/unten begrenzt |
| 3 | Mausrad | Kamera zoomt heran / weg, mit Grenzen |
| 4 | Leertaste | Figur springt und landet wieder |
| 5 | Gegen einen Würfel laufen | Figur bleibt stehen, läuft nicht hindurch |
| 6 | Kamera hinter die Wand drehen | Kamera rückt näher an die Figur, statt durch die Wand zu schauen |
| 7 | Esc drücken | Mauszeiger wird sichtbar; Linksklick ins Spiel fängt ihn wieder ein |
| 8 | Console beobachten | Keine roten Fehler während des Spielens |

Nochmal **Play** drücken beendet den Test. **Achtung:** Änderungen, die du im Play-Modus im Inspector machst,
werden beim Beenden zurückgesetzt – das ist in Unity normal.

Werte ausprobieren (außerhalb des Play-Modus):
- Laufgeschwindigkeit, Sprunghöhe: am `Player` in der Komponente *Player Movement*.
- Mausempfindlichkeit, Zoom, Kamerawinkel: im Asset `MmorpgCameraProfile`.

## Teil 7 – Stand speichern und hochladen

1. Unity speichern (**Strg + S**), dann GitHub Desktop öffnen.
2. Links siehst du die geänderten Dateien. Unten bei *Summary* z. B. eingeben: `Unity-Projekt und Testszene angelegt`.
3. **Commit to main** → oben **Push origin**.

Danach sehe ich das Unity-Projekt im Repository und wir können weitermachen.

## Teil 8 – Rückmeldung an mich

Schick mir:
- die Testtabelle mit ✅ / ❌,
- rote Fehlermeldungen aus der Console (falls vorhanden),
- was sich komisch anfühlt (zu schnell, zu träge, Kamera zu nah, …).
