#r "../NAudio"

open NAudio.Midi
open System.Threading

let midiOut = new MidiOut 0

let startNote note = midiOut.Send(MidiMessage.StartNote(note, 120, 1).RawData)
let stopNote note = midiOut.Send(MidiMessage.StopNote(note, 0, 1).RawData)

let playNote (note, duree:int) =
    startNote note
    Thread.Sleep duree
    stopNote note
   
type Duree = 
    Noire 
    | Blanche 
    | Ronde

let convertDuree duree =
    match duree with
    | Noire -> 500
    | Blanche -> 1000
    | Ronde -> 2000

let DO duree = 60, convertDuree duree
let RE duree = 62, convertDuree duree

let pourChaque = List.map

[ DO Noire; DO Noire; 60, 700; RE Noire; 64, 1000; 62, 1000; 60, 500; 64, 500; 62, 500; 62, 500; 60, 2000 ] 
|> pourChaque playNote

