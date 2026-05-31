	jmp start
	db DA
	db 1C
	db 24
	db FA
	db 0B

start:	
	MOV DL, 02	; указател
	MOV BL, [DL] 	; зареждане на 1-ви елемент
loop:
	INC DL
	CMP DL, 07
	JZ finish
	MOV AL, [DL]
	CMP BL, AL
	JNS skip
	MOV BL, [DL]
skip:
	JMP loop
finish:
	end