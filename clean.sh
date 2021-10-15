#!/bin/sh
find . -type d \( -name 'bin' -o -name 'obj' \) | xargs rm -rfv
