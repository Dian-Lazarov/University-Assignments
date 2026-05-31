	MOV CL, C0
	MOV AL, 30	; '0'

loop:
	MOV [CL], AL	; извеждане
	CMP AL, 3A	; AL = ':'
	JNZ Check_End
	MOV AL, 41	; AL = 'A'
Check_End:
	CMP AL, 46	; AL = 'F'
	JZ finish
	INC AL
	INC CL
	JMP loop
finish:
	END