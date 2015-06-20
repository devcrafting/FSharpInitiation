#r "../Naudio"

open NAudio.Midi
open System.Threading

let MidiOut=new MidiOut(0)

let Startnote note= MidiOut.Send (MidiMessage.StartNote(note,127,1).RawData)
let Stopnote note=MidiOut.Send (MidiMessage.StopNote(note,0,1).RawData)



let playnote note=
    Startnote note

    Thread.Sleep 500
    Stopnote note

playnote 60