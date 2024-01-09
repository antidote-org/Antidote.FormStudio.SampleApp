import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

export default defineConfig({
  plugins: [react()],
  css: {
    postcss: {
        plugins : [
            // autoprefixer
            require('autoprefixer')
        ]
    }
  },
  root: "./src",
  build: {
    outDir: "../dist",
  }
})
