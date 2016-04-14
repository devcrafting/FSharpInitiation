# F# initiation

English & French readme available, see below for English version.

Pour la préparation et le déroulé d'un atelier Mix-Teen, voir [Mix-Teen](Mix-Teen.md)

## Français

Ce repository contient le code issu de plusieurs tentatives d'initiation au F# pour différents publics :

* Avec Simplon en Ardèche (201505), après 7 semaines de découverte de l'informatique et du Ruby, nous avons fait cet atelier en mode CodeCooking (voir ci-dessous)
* En Coding Dojo à Lyon (20150618), avec des développeurs expérimentés découvrant le F#, en mode Code Cooking également
* En atelier Mix-Teen à Lyon (201506), avec 4 enfants de 11 à 14 ans, 2 n'ayant jamais essayé la programmation, en mode Mob Programming (mais sans expliquer les concepts comme dans un Code Cooking)

L'objectif est de partir d'une feuille blanche et de créer un script en s'appuyant la librairie NAudio (donc seulement Windows pour le moment) pour jouer des notes de musique.
Il y a peu de chose à savoir sur cette lib :

* les multiples de 12 sont des DO, i.e 60 est un DO de l'octave 5
* +1 par demi-ton, i.e RE = 62, RE bémol = 61, RE dièse = 63...etc...
* on doit démarrer et arrêter les notes avec une temporisation entre les deux pour créer des croches, des noires...
La temporisation se fait avec Thread.Sleep x, où x est en millisecondes.
* on pourrait donc jouer des accords en démarrant plusieurs notes en même temps...

Pour rejouer, aller plus loin, voici ce qui est nécessaire (tout est gratuit, voire Open Source) :

* PC Windows (pour l'instant, car la lib NAudio utilise les fonctions de son Midi de Windows, je regarde quelle lib utiliser sur Linux...)
* installer FSharp : http://fsharp.org (Open Source, le framework en lui-même fonctionne sous Linux/MacOS...)
* installer un éditeur de code (je conseille Xamarin : plus simple à installer et gratuit)

Pour en savoir plus sur le langage F# : http://fsharp.org ou plus spécifiquement https://msdn.microsoft.com/en-us/library/dd233181.aspx

En cas de problème, ne pas hésiter à me contacter sur Twitter : @clem_bouillier

### A propos du format Code Cooking

J'ai découvert ce format à la conférence NCrafts en mai 2015 avec Emmanuel Gaillot (https://github.com/code-cooking/code-cooking.github.io en construction...).
Ce que j'ai compris de ce format :

* Inspiré des méthodes d'apprentissage accéléré des langues
* Proposer un apprentissage différent basé sur la pratique et l'imprégnation, plutôt que sur la théorie des langues/langages...
* La principale contrainte qui en découle : on n'explique jamais les concepts, on pratique en mimant, les concepts émergent sans être explicités...
* Un format : 1 "enseignant", 3 à 4 "élèves", qui chacun leur tour tentent de reproduire ce que l'enseignant a écrit (exercice de mémoire certes, mais également d'imprégnation, d'appropriation du langage...à mon avis), puis on itère pour avancer et aller de plus en plus loin
* Un autre format (testé avec les enfants) : le Mob Programming, c'est-à-dire on programme tous ensemble en groupe, prenant le clavier chacun son tour pour aller plus loin

NB: les retours sur le fait que c'est plus un exercice de mémoire ou de recopie qu'un réel apprentissage ont été assez fréquents...j'assimile cela plus à de la frustration d'être à la diète de concepts (totalement assumé par le format), à discuter...

## English

TO BE DONE :)
