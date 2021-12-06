Module Program
	Sub Main()
		'Dim variables
		Dim input As Int16 = 0
		Dim maxNum As Int16 = 0
		Dim output(8) As Int16
		Dim hex1(4) As String
		Dim hex2(7) As String
		Dim hexconvert1 As Int16 = 0
		Dim hexconvert2 As Int16 = 0
		Dim hex11 As String = ""
		Dim hex12 As String = ""
		'Asks the user for inputs
		Console.WriteLine("Please enter a number between 0 and 255")
		input = Console.ReadLine()
		
		maxNum = 128
		'Main loop for finding binary
		For c=0 To 7
			If input > 255 Then
				Console.WriteLine("Number too big!")
				Exit For			
			Else
				If input > maxNum Or input = maxNum Then
					input = input - maxNum
					output(c) = 1
				Else
					output(c) = 0
				End If
			maxNum = maxNum / 2
			End If
		Next
		
		'Conversion of the first half of the byte
		For c = 0 To 3
			hex1(c) = output(c)
		Next
		hexconvert1 = ((hex1(0)*128)+(hex1(1)*64)+(hex1(2)*32)+(hex1(3)*16))
		hexconvert1 = hexconvert1 / 16
		Console.WriteLine(hexconvert1)
		If hexconvert1 = 10 Then
			hex11 = "A"
		End If
		If hexconvert1 = 11 Then
			hex11 = "B"
		End If
		If hexconvert1 = 12 Then
			hex11 = "C"
		End If
		If hexconvert1 = 13 Then
			hex11 = "D"
		End If
		If hexconvert1 = 14 Then
			hex11 = "E"
		End If
		If hexconvert1 = 15 Then
			hex11 = "F"
		End If
		Console.WriteLine(hex11)
		'Converson of the second half of the byte
		For c=4 To 7
			hex2(c) = output(c)
		Next
		hexconvert2 = ((hex2(4)*8)+(hex2(5)*4)+(hex2(6)*2)+(hex2(7)*1))
		hexconvert2 = hexconvert2 / 16
		If hexconvert2 = 10 Then
			hex12 = "A"
		End If
		If hexconvert2 = 11 Then
			hex12 = "B"
		End If
		If hexconvert2 = 12 Then
			hex12 = "C"
		End If
		If hexconvert2 = 13 Then
			hex12 = "D"
		End If
		If hexconvert2 = 14 Then
			hex12 = "E"
		End If
		If hexconvert2 = 15 Then
			hex12 = "F"
		End If
		Console.WriteLine("Hex2 " & hex12)
		'prints out hex
		Console.Write("Hex Convert " & hexconvert1 & hexconvert2 & vbCrLf)
		
		Console.WriteLine("HEX answer " & hex11 & " " & hex12)
		
		'prints out the binary
		For c=0 To 7
			Console.Write(output(c))
		Next
		Console.WriteLine(VBCrlf)
		Console.Write(vbCrLf & "Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module