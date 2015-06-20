#r "../NAudio.dll"

open NAudio.Midi

let midiOut = new MidiOut(0)

midiOut.Send(MidiMessage.StartNote(60, 127, 1).RawData)

type Note = int * int

let playNote (note:Note) =
    let note', duree = note
    midiOut.Send(MidiMessage.StartNote(note', 127, 1).RawData)
    System.Threading.Thread.Sleep duree
    midiOut.Send(MidiMessage.StopNote(note', 127, 1).RawData)

let DO = 60
let RE = 62
let MI = 64

let blanche note =
    note, 400

let noire note =
    note, 200

let play = List.map playNote

let partition = [noire DO;noire DO;noire DO;noire RE;blanche MI; blanche DO; noire MI;noire RE;noire RE;blanche DO]

play partition