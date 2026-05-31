TITLE ArrayCopy_vX
; ВЕРСИЯ X
; Поелементно копиране на масив

INCLUDE Irvine32.inc    ; библиотечни фунцкции
INCLUDE Macros.inc      ; дефиниции на макроси

.586                    ; процесор с налична инструкция rdtsc
; ----------------- Arrays ----------------
.data
sarray  DWORD   100000 DUP(1)   ; масив „източник”
darray  DWORD   100000 DUP(0)   ; масив „приемник”

.code
main PROC
    
    xor eax, eax
    cpuid   ; Сериализация
    rdtsc   ; Четене на брояча на циклите в <EDX:EAX>
    
    push EDX    ; Запазване в стека на време t1
    push EAX
    
    mov	EBX, LENGTHOF sarray    ; EBX е брояч на външния цикъл
;===============================================
main_loop:                      ; Външен цикъл
    mov ECX, LENGTHOF sarray    ; ECX е брояч на вътрешния цикъл
    lea ESI, DWORD PTR sarray   ; ESI = aдрес на масива “източник”
    lea EDI, DWORD PTR darray   ; EDI = aдрес на масива “приемник”
; ----------------------------------------------
body:	        ; Вътрешен цикъл (копиране на масива)
    rep movsd
; ----------------------------------------------

    dec EBX                 ; Декремент на брояча на външния цикъл
    jnz main_loop           ; Преход към следваща итерация
;===============================================

    rdtsc       ; Четене на брояча на циклите в <EDX:EAX>
   
    pop ESI     ; Прочитане от стека на време t1   
    pop EDI     
    
    sub EAX, ESI    ; Намиране на разликата t2-t1
    sbb EDX, EDI

    ShowRegister EDX, EDX   ; Извеждане на резултата
    ShowRegister EAX, EAX
    cpuid                   ; Сериализация
    
    exit
main ENDP
END main