#r "../NAudio.dll"

open NAudio.Midi

let midiOut = new MidiOut(0)

midiOut.Send(MidiMessage.StartNote(60, 127, 1).RawData)

type Note = { Hauteur: int; Duree: int }

let playNote note = 
    midiOut.Send(MidiMessage.StartNote(note.Hauteur, 127, 1).RawData)
    System.Threading.Thread.Sleep note.Duree
    midiOut.Send(MidiMessage.StopNote(note.Hauteur, 127, 1).RawData)

let SOL = 60
let LA = 62
let SI = 64

let blanche note =
    { Hauteur = note; Duree = 400}

let noire note =
    { Hauteur = note; Duree = 200}

let partition = [ noire SOL; noire SOL; noire SOL; noire LA; blanche SI; blanche LA; noire SOL; noire SI; noire LA; noire LA; noire SOL ]
partition |> List.map playNote