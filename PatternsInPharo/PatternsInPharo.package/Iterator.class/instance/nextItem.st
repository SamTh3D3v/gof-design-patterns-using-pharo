operations
nextItem
	(currentIndex < aggregate size) ifTrue: [ currentIndex := currentIndex + 1. ^aggregate get: currentIndex] ifFalse:[^nil].
	