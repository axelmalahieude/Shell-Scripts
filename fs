#!/bin/bash

# Inverts scrolling when plugging in my mouse. Called 'fs' (fix scrolling)
# to be easily typed. Executes the following commands, using grep/sed to
# gather arguments:
# xinput list
# xinput list-props <mouse-id>
# xinput set-prop <mouse-id> <prop-num> 0


ID=`xinput list | grep 'Comp.*pointer' | sed 's/.*id=\([[:digit:]]*\).*/\1/'`
PROP=`xinput list-props $ID | grep 'Natural Scrolling Enabled (' |\
sed 's/.*(\([[:digit:]]*\).*/\1/'`

`xinput set-prop $ID $PROP 0`

