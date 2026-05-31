	jmp start
	db "0123456789ABCDEF"

start:	

	MOV CL, C0
	MOV DL, 02	; DL – указател към стринга
loop:	
	MOV AL, [DL]
	MOV [CL], AL
	CMP DL, 11
	JZ finish
	INC CL
	INC DL
	JMP loop
finish:
	end