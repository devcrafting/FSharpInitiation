#r "../NAudio"

open NAudio.Midi
open System.Threading

let midiOut = new MidiOut(0)

let startNote note = midiOut.Send(MidiMessage.StartNote(note, 128, 1).RawData)
let stopNote note = midiOut.Send(MidiMessage.StopNote(note, 0, 1).RawData)

let playNote (note, sleep:int) =
    startNote note
    Thread.Sleep sleep
    stopNote note
   
type Duree =
    Noire
    | Blanche
    | Ronde

let convertDuree duree =
    match duree with
    | Noire -> 250
    | Blanche -> 500
    | Ronde -> 1000

let DO duree = 
    60, convertDuree duree

playNote (DO Noire)
playNote (DO Noire)
playNote 60 500
playNote 62 500
playNote 64 1000
playNote 62 1000
playNote 60 500
playNote 64 500
playNote 62 500
playNote 62 500
playNote 60 2000

let add x y = int x + int y

add (float 3) (float 1)
float 3