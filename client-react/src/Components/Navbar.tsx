import { Link } from 'react-router-dom'

const Navbar = () => {
  return (
    <nav className="bg-white shadow-md">
      <div className="max-w-7xl mx-auto px-6">
        <div className="flex justify-between items-center h-16">
          {/* Logo / Título */}
          <Link
            to="/"
            className="text-2xl font-extrabold text-gray-800 tracking-wide hover:text-blue-600 transition-colors"
          >
            Product Store
          </Link>

          {/* Botón de acción */}
          <Link
            to="/create-product"
            className="bg-blue-600 hover:bg-blue-700 text-white px-5 py-2 rounded-lg shadow-md font-semibold transition-all duration-200"
          >
            Add New Product
          </Link>
        </div>
      </div>
    </nav>

  )
}

export default Navbar
