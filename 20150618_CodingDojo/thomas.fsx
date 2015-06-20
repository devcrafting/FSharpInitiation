#r "../NAudio.dll"

open NAudio.Midi

let midiOut = new MidiOut(0)

midiOut.Send(MidiMessage.StartNote(60, 127, 1).RawData)

let playNote (note: int * int) =
    let hauteur, duree = note
    midiOut.Send(MidiMessage.StartNote(hauteur, 127, 1).RawData)
    System.Threading.Thread.Sleep duree
    midiOut.Send(MidiMessage.StopNote(hauteur, 127, 1).RawData)

let DO = 60
let RE = 62
let MI = 64

let noire note =
    note, 200

let blanche note =
    note, 400

[noire DO;noire DO;noire DO;noire RE;blanche MI;blanche RE;noire DO;noire MI;noire RE;noire RE;noire DO]
|> List.map playNote