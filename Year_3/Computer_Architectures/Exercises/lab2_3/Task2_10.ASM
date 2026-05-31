JMP start
	DB 01
	DB 02
	DB 03
	DB 04
	DB 05
	DB 06
	DB 07
	DB 08
	DB 09
	DB 0A

start:
	MOV DL, 02	; указател към масива
	MOV AL, 0	; сума

sum_loop:
	MOV BL, [DL]
	ADD AL, BL
	CMP DL, 0B
	JZ finish
	INC DL
	JMP sum_loop

finish:
	MOV [C0], AL
	HALT
	END