# Commands used in this repository

```
yarn init -y
yarn add express
yarn add @types/express -D
```

```
yarn add typescript -D
yarn tsc --init
```
Change `tsconfig.json`:
```json
"target": "es5",
"module": "commonjs",
```
to:
```json
"target": "es2017",
"module": "commonjs",
```

```
yarn add ts-node-dev -D
```
Add in `package.json`:
```json
"scripts": {
  "start": "ts-node-dev src/server.ts"
}
```
Optimization:
```json
"scripts": {
  "start": "ts-node-dev --transpile-only --ignore-watch node_modules src/server.ts"
}
```
ORM and Database:
```
yarn add typeorm sqlite3
```
Handing with images in backend:
```
yarn add multer
```
Handing with exceptions
```
yarn add express-async-errors
```
Validation:
```
yarn add yup
```
```
yarn add cors
```