TITLE Task5_5      (Task5_5.asm)

; This program scans an array of words for the second nonzero value.
INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
wArray WORD  0,0,0,0,0,20,35,12,66,4,0
;wArray WORD  1,0,0,0
;wArray WORD  0,0,0,0
notFoundMsg  BYTE "A non-zero value was not found",0

.code
main PROC
    ; Разпределение на регистрите:
    ; EBX - брояч на откритите ненулеви елементи
    ; ESI - указател към паметта на масива
    ; ECX - брояч за оставащите елементи в масива (цикъла)
    ; EAX - буфер за четене и краен резултат
    
    MOV EBX, 0                  ; Нулираме брояча за ненулеви елементи
    MOV ESI, OFFSET wArray      ; Насочваме ESI към началото на масива
    MOV ECX, LENGTHOF wArray    ; Зареждаме общия брой елементи в ECX
    
    XOR EAX, EAX                ; Изчистваме EAX напълно (важно за ShowRegister)

scan_loop:
    MOV AX, [ESI]               ; Четем поредния 16-битов елемент (WORD) в AX
    CMP AX, 0                   ; Проверяваме дали е нула
    JZ skip                     ; Ако Е нула, прескачаме го
    
    ; Ако стигнем тук, сме намерили ненулево число
    INC EBX                     ; Увеличаваме брояча на ненулевите елементи
    CMP EBX, 2                  ; Проверяваме дали това е ВТОРИЯТ намерен елемент
    JZ found                    ; Ако е вторият, излизаме от цикъла към етикет 'found'

skip:
    ADD ESI, TYPE wArray        ; Местим указателя към следващия елемент (2 байта напред)
    DEC ECX                     ; Намаляваме оставащия брой елементи
    JNZ scan_loop               ; Ако не сме обходили целия масив, продължаваме
    
    ; Ако цикълът приключи и стигнем до този ред, 
    ; значи в масива НЯМА два ненулеви елемента.
    JMP notFound

found:
    ShowRegister eax, eax       ; EAX вече съдържа втория ненулев елемент
    jmp  quit

notFound:
    mov  edx, OFFSET notFoundMsg    ; display "not found" message
    call WriteString
    call Crlf                   ; Добра практика: минаваме на нов ред след текста

quit:
    exit
main ENDP
END main