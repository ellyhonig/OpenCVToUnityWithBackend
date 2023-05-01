

;; 1. Design, code and prove correct a recursive function takeWhile, with signature

;;     (takeWhile pred lst)

;; and usage illustrated

;;     (takeWhile (lambda (x) (<= 10 x)) '(1 2 3 4 11 12 1 9)) = (1 2 3 4)

;; Be sure to complete the specification. 



(define (takeWhile pred lst)
  (cond ((null? lst) '())
        ((not (pred (car lst))) '())
        (else (cons (car lst) (takeWhile pred (cdr lst))))))


;; proof by induction on the length of lst, which ought not be assumed to be a lat


;; scoring must take into account that the example I gave on the quiz was wrong: I wrote <=
;; when it ought to have been >=.


;; what about an iterative solution?

(define (takeWhileI pred lst)

;; GI :   (append (reverse rsf) largest-initial-segment-of-remaining-whose-elts-satisfy-pred) =
;;  largest-initial-segment-of-lst-whose-elts-satisfy-pred
  (define (iter remaining rsf)
    (cond ((null? remaining) (reverse rsf))
          ((not (pred (car remaining))) (reverse rsf))
          (else (iter (cdr remaining) (cons (car remaining) rsf)))))
  
  (iter lst '()))



;; problem counts for as many as 3 points

;; spec 0.5, code 1, proof 1.5



;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;


;; 2. A list of pairs, such as ((1 2)(1 3)(3 4)) in which some pairs have the same
;; first element, can be regarded as a relation - for example, we can regard this list
;; as defining a relation r with r(1) = {2,3} and r(3) = {4}.

;; It would be nice to have a way of transforming a relation list with repeated first
;; elements to one without repeated first elements.  Were we to do this with a function
;; named pairsToRelations, we would have, for example,

;; (pairsToRelation '((1 3)(3 4)(1 3) (2 5) (1 6) (1 2) (3 7))) =
;;      '( (1 (3 2 6)) (3 (4 7)) (2 (5)) )

;; Specify, design and prove a function pairsToRelation which does this job for us.  


(define (pairs-to-relation lst-of-pairs)
  (cond ((null? lst-of-pairs) '())
        (else (let ((first (caar lst-of-pairs)))
                (cons (list first (make-list-of-second-elts first lst-of-pairs))
                      (pairs-to-relation (remove-all-pairs-with-first first lst-of-pairs)))))))

(define (make-list-of-second-elts first-elt remaining)
  (cond ((null? remaining) '())
        ((eq? first-elt (caar remaining)) (cons (cadar remaining)
                                                   (make-list-of-second-elts first-elt (cdr remaining))))
        (else (make-list-of-second-elts first-elt (cdr remaining)))))
                                               

(define (remove-all-pairs-with-first first lst-of-pairs)
  (cond ((null? lst-of-pairs) '())
        ((eq? (caar lst-of-pairs) first) (remove-all-pairs-with-first first (cdr lst-of-pairs)))
        (else (cons (car lst-of-pairs) (remove-all-pairs-with-first first (cdr lst-of-pairs))))))


;; problem counts for as many as 5 points --

;;  functional decomposition 1
;;  development and code for main function 2
;;  development and code for first helper 1
;;  development and code for second helper 1

