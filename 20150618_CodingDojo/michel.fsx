#r "../Naudio.dll"

open NAudio.Midi

let midi=new MidiOut(0)

midi.Send(MidiMessage.StartNote(60,127,1).RawData)

let play note =

    midi.Send(MidiMessage.StartNote(note,127,1).RawData)
    System.Threading.Thread.Sleep 200
    midi.Send(MidiMessage.StopNote(note,127,1).RawData)

play 60

let SOL = 60
let LA  = 62
let SI  = 64
[SOL; SOL; SOL; LA; SI; LA; SOL; SI; LA; LA; SOL]
|> List.map play 