#r "NAudio.dll"

open NAudio.Midi

let midiOut = new MidiOut(0)

let commencer note = midiOut.Send(MidiMessage.StartNote(note, 127, 1).RawData)
let arreter note = midiOut.Send(MidiMessage.StopNote(note, 0, 1).RawData)
let attendre (duree:int) = System.Threading.Thread.Sleep(duree)

type Octave = int
type Duree =
    | C
    | N
    | Np
    | B
    | Bp
type Note =
    | DO of Octave * Duree | SId of Octave * Duree
    | DOd of Octave * Duree | REb of Octave * Duree
    | RE of Octave * Duree
    | REd of Octave * Duree | MIb of Octave * Duree
    | MI of Octave * Duree | FAb of Octave * Duree
    | FA of Octave * Duree | MId of Octave * Duree
    | FAd of Octave * Duree | SOLb of Octave * Duree
    | SOL of Octave * Duree
    | SOLd of Octave * Duree | LAb of Octave * Duree
    | LA of Octave * Duree
    | LAd of Octave * Duree | SIb of Octave * Duree
    | SI of Octave * Duree | DOb of Octave * Duree

let attente duree tempo =
    let millisecond = 
        match duree with
            | C -> 200
            | N -> 400
            | Np -> 600
            | B -> 800
            | Bp -> 1200
    int ((float millisecond)/(float tempo)*100.0)

let jouer tempo note =
    let hauteur, duree = 
        match note with
            | DO (octave, duree) | SId (octave, duree) ->  12*octave, duree
            | DOd (octave, duree) | REb (octave, duree) ->  12*octave+1, duree
            | RE (octave, duree) ->  12*octave+2, duree
            | REd (octave, duree) | MIb (octave, duree) ->  12*octave+3, duree
            | MI (octave, duree) | FAb (octave, duree) ->  12*octave+4, duree
            | FA (octave, duree) | MId (octave, duree) ->  12*octave+5, duree
            | FAd (octave, duree) | SOLb (octave, duree) ->  12*octave+6, duree
            | SOL (octave, duree) ->  12*octave+7, duree
            | SOLd (octave, duree) | LAb (octave, duree) ->  12*octave+8, duree
            | LA (octave, duree) ->  12*octave+9, duree
            | LAd (octave, duree) | SIb (octave, duree) ->  12*octave+10, duree
            | SI (octave, duree) | DOb (octave, duree) ->  12*octave+11, duree
    commencer hauteur
    attendre (attente duree tempo) 
    arreter hauteur

let jouerLigne tempo ligne =
    ligne
    |> List.map (jouer tempo)
let jouerPartition partition tempo =
    partition
    |> List.map (jouerLigne tempo)

let ligne1 = [ RE (5, N); SOL (5, N); LAd (5, C); LA (5, N); SOL (5, B); RE (6, N); DO (6, Bp) ]
let ligne2 = [LA (5, Bp); SOL (5, N); LAd (5, C); LA (5, N); FAd (5, B); SOLd (5, N); RE (5, Bp) ] 
let ligne3 = [RE (5, B); RE (5, N); SOL (5, Np); LAd (5, C); LA (5, N); SOL (5, B); RE (6, N); FA (6, B); MI (6, N) ]
let ligne4 = [REd (6, B); SI (5, N); REd (6, Np); RE (6, C); DOd (6, N); DOd (5, B); LAd (5, N); SOL (5, Bp)]
let harryPotter = [ligne1; ligne2; ligne3; ligne4]

jouerPartition harryPotter 152

let lettreAElise = [[ MI (6, C); REd (6, C) ; MI (6, C); REd (6, C); MI (6, C); SI (5, C) ; RE (6, C) ; DO (6, C) ; LA (5, N) ]]
jouerPartition lettreAElise 120