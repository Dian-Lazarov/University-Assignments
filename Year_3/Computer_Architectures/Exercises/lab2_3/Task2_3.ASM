	MOV CL, C0	; начален адрес на видео паметта (VDU)
loop:
	IN 00		; четене от клавиатурата
	MOV [CL], AL
	CMP AL, 0D	; Enter ?
	JZ finish	; край
	INC CL		; CL = CL + 1
	JMP loop
finish:
	END