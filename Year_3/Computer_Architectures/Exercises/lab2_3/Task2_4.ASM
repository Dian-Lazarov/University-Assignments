	MOV CL, C0
	MOV AL, 30	; '0'
loop:
	MOV [CL], AL	; извеждане
	CMP AL, 39	; AL = '9'
	JZ finish
	INC AL
	INC CL
	JMP loop
finish:
	END